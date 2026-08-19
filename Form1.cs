using Discord;
using Discord.WebSocket;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace wiwiwi
{
    public partial class Form1 : Form
    {
        private DiscordSocketClient? _client;
        private Dictionary<ulong, string> _userCache = new Dictionary<ulong, string>();
        private ulong? _selectedUserId = null;
        private static readonly HttpClient httpClient = new HttpClient();
        private string? _captchaApiKey = null;

        public Form1()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(54, 57, 63);
        }

        private async void btnCheckToken_Click(object sender, EventArgs e)
        {
            string token = txtToken.Text.Trim();

            if (string.IsNullOrEmpty(token))
            {
                lblStatus.Text = "Please enter a token.";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            btnCheckToken.Enabled = false;
            btnLogin.Enabled = false;
            lblStatus.Text = "Checking token status...";
            lblStatus.ForeColor = System.Drawing.Color.Blue;
            lblTokenStatus.Text = "";
            lblVerificationStatus.Text = "";

            try
            {
                using (var client = new DiscordSocketClient())
                {
                    client.Log += Log;

                    try
                    {
                        await client.LoginAsync(TokenType.Bot, token);
                        await client.StartAsync();

                        // Wait a moment for connection
                        await Task.Delay(2000);

                        if (client.ConnectionState == ConnectionState.Connected && client.CurrentUser != null)
                        {
                            lblTokenStatus.Text = "Token Status: Active ✓";
                            lblTokenStatus.ForeColor = System.Drawing.Color.Green;

                            // Check verification status based on user properties
                            bool needsVerification = !client.CurrentUser.IsVerified;
                            bool isPhoneVerified = client.CurrentUser.IsVerified;

                            if (isPhoneVerified)
                            {
                                lblVerificationStatus.Text = "Verification Status: Verified (Phone verified) ✓";
                                lblVerificationStatus.ForeColor = System.Drawing.Color.Green;
                            }
                            else
                            {
                                lblVerificationStatus.Text = "Verification Status: Needs Verification (Phone not verified) ⚠";
                                lblVerificationStatus.ForeColor = System.Drawing.Color.Orange;
                            }

                            lblStatus.Text = "Token check completed successfully!";
                            lblStatus.ForeColor = System.Drawing.Color.Green;
                        }
                        else
                        {
                            lblTokenStatus.Text = "Token Status: Inactive ✗";
                            lblTokenStatus.ForeColor = System.Drawing.Color.Red;
                            lblVerificationStatus.Text = "Verification Status: Unknown (Token invalid)";
                            lblVerificationStatus.ForeColor = System.Drawing.Color.Red;
                            lblStatus.Text = "Token is invalid or inactive.";
                            lblStatus.ForeColor = System.Drawing.Color.Red;
                        }

                        await client.StopAsync();
                    }
                    catch (Exception ex)
                    {
                        lblTokenStatus.Text = "Token Status: Inactive ✗";
                        lblTokenStatus.ForeColor = System.Drawing.Color.Red;
                        lblVerificationStatus.Text = "Verification Status: Unknown (Token invalid)";
                        lblVerificationStatus.ForeColor = System.Drawing.Color.Red;
                        lblStatus.Text = $"Token check failed: {ex.Message}";
                        lblStatus.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"Error during token check: {ex.Message}";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
            finally
            {
                btnCheckToken.Enabled = true;
                if (_client == null || _client.ConnectionState != ConnectionState.Connected)
                {
                    btnLogin.Enabled = true;
                    btnLogin.Text = "Login";
                }
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string token = txtToken.Text.Trim();

            if (string.IsNullOrEmpty(token))
            {
                lblStatus.Text = "Please enter a token.";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            btnLogin.Enabled = false;
            btnCheckToken.Enabled = false;
            lblStatus.Text = "Connecting to Discord...";
            lblStatus.ForeColor = System.Drawing.Color.Blue;

            try
            {
                // Dispose existing client if any
                if (_client != null)
                {
                    await _client.StopAsync();
                    _client.Dispose();
                }

                _client = new DiscordSocketClient();

                _client.Log += Log;
                _client.Ready += OnReady;

                await _client.LoginAsync(TokenType.Bot, token);
                await _client.StartAsync();

                lblStatus.Text = "Login successful! Client connected for message sending.";
                lblStatus.ForeColor = System.Drawing.Color.Green;
                btnLogin.Text = "Connected";
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"Login failed: {ex.Message}";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                btnLogin.Enabled = true;
                btnCheckToken.Enabled = true;
                btnLogin.Text = "Login";

                if (_client != null)
                {
                    await _client.StopAsync();
                    _client.Dispose();
                    _client = null;
                }
            }
        }

        private async Task OnReady()
        {
            if (_client != null && _client.CurrentUser != null)
            {
                this.Invoke((MethodInvoker)delegate {
                    lblUserInfo.Text = $"Logged in as: {_client.CurrentUser.Username}#{_client.CurrentUser.Discriminator}";
                    lblUserInfo.ForeColor = System.Drawing.Color.Green;
                    btnCheckToken.Enabled = true;
                });

                // Load friends/DMs
                await LoadUsersAsync();
            }
            await Task.CompletedTask;
        }

        private async Task LoadUsersAsync()
        {
            if (_client == null) return;

            try
            {
                _userCache.Clear();
                lstUsers.Items.Clear();

                // Try to get users from guilds
                bool usersFound = false;
                try
                {
                    var guilds = _client.Guilds;
                    foreach (var guild in guilds)
                    {
                        await foreach (var users in guild.GetUsersAsync())
                        {
                            foreach (var user in users)
                            {
                                if (user.Id != _client.CurrentUser.Id)
                                {
                                    string displayName = $"{user.Username}#{user.Discriminator}";
                                    if (!_userCache.ContainsKey(user.Id))
                                    {
                                        _userCache[user.Id] = displayName;
                                        this.Invoke((MethodInvoker)delegate {
                                            lstUsers.Items.Add(displayName);
                                        });
                                        usersFound = true;
                                    }
                                }
                            }
                        }
                    }
                }
                catch
                {
                    // Guild access might not be available
                }

                this.Invoke((MethodInvoker)delegate {
                    if (!usersFound)
                    {
                        lstUsers.Items.Add("No users found - add User ID below");
                    }
                });
            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)delegate {
                    lstUsers.Items.Add($"Error loading users: {ex.Message}");
                });
            }
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUsers.SelectedIndex == -1) return;

            string selectedUser = lstUsers.SelectedItem.ToString();
            if (selectedUser.StartsWith("No users found") || selectedUser.StartsWith("Error"))
            {
                _selectedUserId = null;
                lblSelectedUser.Text = "";
                rtbConversation.Text = "Select a valid user to start messaging.";
                return;
            }

            // Find the user ID from the cache
            foreach (var kvp in _userCache)
            {
                if (kvp.Value == selectedUser)
                {
                    _selectedUserId = kvp.Key;
                    lblSelectedUser.Text = $"Chatting with: {selectedUser}";
                    rtbConversation.Text = $"Conversation with {selectedUser}:\n\n";
                    break;
                }
            }
        }

        private void lblGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/Praydevs",
                UseShellExecute = true
            });
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string userIdStr = txtUserId.Text.Trim();

            if (string.IsNullOrEmpty(userIdStr))
            {
                lblMessageStatus.Text = "Please enter a User ID.";
                lblMessageStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (!ulong.TryParse(userIdStr, out ulong userId))
            {
                lblMessageStatus.Text = "Invalid User ID format.";
                lblMessageStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            // Add to cache with ID as display name (we'll get the actual name when we DM them)
            string displayName = $"User {userId}";
            if (!_userCache.ContainsKey(userId))
            {
                _userCache[userId] = displayName;
                lstUsers.Items.Add(displayName);
                lblMessageStatus.Text = "User added! Select them to start chatting.";
                lblMessageStatus.ForeColor = System.Drawing.Color.Green;
                txtUserId.Text = "";
            }
            else
            {
                lblMessageStatus.Text = "User already in list.";
                lblMessageStatus.ForeColor = System.Drawing.Color.Orange;
            }
        }

        private async void btnBulkDM_Click(object sender, EventArgs e)
        {
            if (_client == null || _client.ConnectionState != ConnectionState.Connected)
            {
                lblBulkDMStatus.Text = "Please login first before sending bulk DMs.";
                lblBulkDMStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            string message = txtBulkMessage.Text.Trim();

            if (string.IsNullOrEmpty(message))
            {
                lblBulkDMStatus.Text = "Please enter a message.";
                lblBulkDMStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (_userCache.Count == 0)
            {
                lblBulkDMStatus.Text = "No users in list. Add users first.";
                lblBulkDMStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            btnBulkDM.Enabled = false;
            lblBulkDMStatus.Text = "Sending bulk DMs...";
            lblBulkDMStatus.ForeColor = System.Drawing.Color.Blue;

            int successCount = 0;
            int failCount = 0;

            try
            {
                foreach (var userId in _userCache.Keys)
                {
                    try
                    {
                        var dmChannel = await _client.GetDMChannelAsync(userId);
                        if (dmChannel != null)
                        {
                            await dmChannel.SendMessageAsync(message);
                            successCount++;
                            await Task.Delay(1000); // Rate limiting
                        }
                        else
                        {
                            failCount++;
                        }
                    }
                    catch
                    {
                        failCount++;
                    }
                }

                lblBulkDMStatus.Text = $"Bulk DM complete: {successCount} sent, {failCount} failed";
                lblBulkDMStatus.ForeColor = successCount > 0 ? System.Drawing.Color.Green : System.Drawing.Color.Red;
            }
            catch (Exception ex)
            {
                lblBulkDMStatus.Text = $"Bulk DM failed: {ex.Message}";
                lblBulkDMStatus.ForeColor = System.Drawing.Color.Red;
            }
            finally
            {
                btnBulkDM.Enabled = true;
            }
        }

        private async void btnJoinServer_Click(object sender, EventArgs e)
        {
            string invite = txtInvite.Text.Trim();
            string token = txtJoinToken.Text.Trim();

            if (string.IsNullOrEmpty(invite))
            {
                lblJoinStatus.Text = "Please enter a server invite.";
                lblJoinStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(token))
            {
                lblJoinStatus.Text = "Please enter a token.";
                lblJoinStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            btnJoinServer.Enabled = false;
            lblJoinStatus.Text = "Joining server...";
            lblJoinStatus.ForeColor = System.Drawing.Color.Blue;

            try
            {
                using (var client = new DiscordSocketClient())
                {
                    await client.LoginAsync(TokenType.Bot, token);
                    await client.StartAsync();

                    await Task.Delay(2000); // Wait for connection

                    // Extract invite code from full URL if needed
                    string inviteCode = invite;
                    if (invite.Contains("discord.gg/"))
                    {
                        inviteCode = invite.Split("discord.gg/")[1].Split('/')[0];
                    }
                    else if (invite.Contains("discord.com/invite/"))
                    {
                        inviteCode = invite.Split("discord.com/invite/")[1].Split('/')[0];
                    }

                    // Use HTTP client to accept invite
                    Form1.httpClient.DefaultRequestHeaders.Clear();
                    Form1.httpClient.DefaultRequestHeaders.Add("Authorization", token);
                    var response = await Form1.httpClient.PostAsync($"https://discord.com/api/v10/invites/{inviteCode}", null);
                    
                    if (response.IsSuccessStatusCode)
                    {
                        lblJoinStatus.Text = "Successfully joined server!";
                    }
                    else
                    {
                        var errorContent = await response.Content.ReadAsStringAsync();
                        throw new Exception($"Failed to join: {response.StatusCode} - {errorContent}");
                    }
                    lblJoinStatus.ForeColor = System.Drawing.Color.Green;

                    await client.StopAsync();
                }
            }
            catch (Exception ex)
            {
                lblJoinStatus.Text = $"Failed to join server: {ex.Message}";
                lblJoinStatus.ForeColor = System.Drawing.Color.Red;
            }
            finally
            {
                btnJoinServer.Enabled = true;
            }
        }

        private async void btnBoost_Click(object sender, EventArgs e)
        {
            string serverId = txtBoostServerId.Text.Trim();
            string token = txtBoostToken.Text.Trim();
            _captchaApiKey = txtCaptchaApiKey.Text.Trim();

            if (string.IsNullOrEmpty(serverId))
            {
                lblBoostStatus.Text = "Please enter a server ID.";
                lblBoostStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(token))
            {
                lblBoostStatus.Text = "Please enter a token.";
                lblBoostStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(_captchaApiKey))
            {
                lblBoostStatus.Text = "Please enter 2Captcha API key in Settings.";
                lblBoostStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            btnBoost.Enabled = false;
            lblBoostStatus.Text = "Boosting server (solving captcha)...";
            lblBoostStatus.ForeColor = System.Drawing.Color.Blue;

            try
            {
                // Solve captcha first
                string captchaSolution = await SolveCaptchaAsync();
                if (string.IsNullOrEmpty(captchaSolution))
                {
                    throw new Exception("Failed to solve captcha");
                }

                // Use HTTP client to boost server
                Form1.httpClient.DefaultRequestHeaders.Clear();
                Form1.httpClient.DefaultRequestHeaders.Add("Authorization", token);
                
                var boostData = new
                {
                    server_id = serverId,
                    captcha_key = captchaSolution
                };

                var jsonContent = System.Text.Json.JsonSerializer.Serialize(boostData);
                var content = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");
                
                var response = await Form1.httpClient.PostAsync($"https://discord.com/api/v10/guilds/{serverId}/premium/subscriptions", content);
                
                if (response.IsSuccessStatusCode)
                {
                    lblBoostStatus.Text = "Successfully boosted server!";
                    lblBoostStatus.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Failed to boost: {response.StatusCode} - {errorContent}");
                }
            }
            catch (Exception ex)
            {
                lblBoostStatus.Text = $"Failed to boost: {ex.Message}";
                lblBoostStatus.ForeColor = System.Drawing.Color.Red;
            }
            finally
            {
                btnBoost.Enabled = true;
            }
        }

        private async void btnBulkBoost_Click(object sender, EventArgs e)
        {
            string serverId = txtBulkBoostServerId.Text.Trim();
            string tokens = txtBulkBoostTokens.Text.Trim();
            _captchaApiKey = txtCaptchaApiKey.Text.Trim();

            if (string.IsNullOrEmpty(serverId))
            {
                lblBulkBoostStatus.Text = "Please enter a server ID.";
                lblBulkBoostStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(tokens))
            {
                lblBulkBoostStatus.Text = "Please enter tokens (one per line).";
                lblBulkBoostStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(_captchaApiKey))
            {
                lblBulkBoostStatus.Text = "Please enter 2Captcha API key in Settings.";
                lblBulkBoostStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            btnBulkBoost.Enabled = false;
            lblBulkBoostStatus.Text = "Bulk boosting servers...";
            lblBulkBoostStatus.ForeColor = System.Drawing.Color.Blue;

            string[] tokenList = tokens.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            int successCount = 0;
            int failCount = 0;

            try
            {
                foreach (string token in tokenList)
                {
                    try
                    {
                        // Solve captcha for each token
                        string captchaSolution = await SolveCaptchaAsync();
                        if (string.IsNullOrEmpty(captchaSolution))
                        {
                            failCount++;
                            continue;
                        }

                        Form1.httpClient.DefaultRequestHeaders.Clear();
                        Form1.httpClient.DefaultRequestHeaders.Add("Authorization", token.Trim());
                        
                        var boostData = new
                        {
                            server_id = serverId,
                            captcha_key = captchaSolution
                        };

                        var jsonContent = System.Text.Json.JsonSerializer.Serialize(boostData);
                        var content = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");
                        
                        var response = await Form1.httpClient.PostAsync($"https://discord.com/api/v10/guilds/{serverId}/premium/subscriptions", content);
                        
                        if (response.IsSuccessStatusCode)
                        {
                            successCount++;
                        }
                        else
                        {
                            failCount++;
                        }

                        await Task.Delay(5000); // Rate limiting between boosts
                    }
                    catch
                    {
                        failCount++;
                    }
                }

                lblBulkBoostStatus.Text = $"Bulk boost complete: {successCount} boosted, {failCount} failed";
                lblBulkBoostStatus.ForeColor = successCount > 0 ? System.Drawing.Color.Green : System.Drawing.Color.Red;
            }
            catch (Exception ex)
            {
                lblBulkBoostStatus.Text = $"Bulk boost failed: {ex.Message}";
                lblBulkBoostStatus.ForeColor = System.Drawing.Color.Red;
            }
            finally
            {
                btnBulkBoost.Enabled = true;
            }
        }

        private async Task<string> SolveCaptchaAsync()
        {
            if (string.IsNullOrEmpty(_captchaApiKey))
            {
                return null;
            }

            try
            {
                // Create a simple text captcha task for 2Captcha
                // In a real implementation, you'd need to handle actual captcha images
                var captchaId = await CreateCaptchaTaskAsync();
                if (string.IsNullOrEmpty(captchaId))
                {
                    return null;
                }

                // Wait for solution
                await Task.Delay(15000); // Wait for captcha to be solved (15 seconds)
                var solution = await GetCaptchaSolutionAsync(captchaId);
                return solution;
            }
            catch
            {
                return null;
            }
        }

        private async Task<string> CreateCaptchaTaskAsync()
        {
            try
            {
                // This is a simplified implementation
                // In reality, you'd need to send actual captcha data to 2Captcha
                var response = await Form1.httpClient.PostAsync($"http://2captcha.com/in.php?key={_captchaApiKey}&method=userrecaptcha&googlekey=6Le-wvkSAAAAAPBMRTvw0Q4Muexq9bi0DJwx_mJ-&pageurl=https://discord.com", null);
                var content = await response.Content.ReadAsStringAsync();
                
                if (content.StartsWith("OK|"))
                {
                    return content.Substring(3);
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        private async Task<string> GetCaptchaSolutionAsync(string captchaId)
        {
            try
            {
                var response = await Form1.httpClient.GetAsync($"http://2captcha.com/res.php?key={_captchaApiKey}&action=get&id={captchaId}");
                var content = await response.Content.ReadAsStringAsync();
                
                if (content.StartsWith("OK|"))
                {
                    return content.Substring(3);
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        private async void btnBulkJoin_Click(object sender, EventArgs e)
        {
            string invite = txtBulkInvite.Text.Trim();
            string tokens = txtBulkTokens.Text.Trim();

            if (string.IsNullOrEmpty(invite))
            {
                lblBulkJoinStatus.Text = "Please enter a server invite.";
                lblBulkJoinStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(tokens))
            {
                lblBulkJoinStatus.Text = "Please enter tokens (one per line).";
                lblBulkJoinStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            btnBulkJoin.Enabled = false;
            lblBulkJoinStatus.Text = "Bulk joining servers...";
            lblBulkJoinStatus.ForeColor = System.Drawing.Color.Blue;

            // Extract invite code from full URL if needed
            string inviteCode = invite;
            if (invite.Contains("discord.gg/"))
            {
                inviteCode = invite.Split("discord.gg/")[1].Split('/')[0];
            }
            else if (invite.Contains("discord.com/invite/"))
            {
                inviteCode = invite.Split("discord.com/invite/")[1].Split('/')[0];
            }

            string[] tokenList = tokens.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            int successCount = 0;
            int failCount = 0;

            try
            {
                foreach (string token in tokenList)
                {
                    try
                    {
                        using (var client = new DiscordSocketClient())
                        {
                            await client.LoginAsync(TokenType.Bot, token.Trim());
                            await client.StartAsync();

                            await Task.Delay(2000); // Wait for connection

                            // Use HTTP client to accept invite
                            Form1.httpClient.DefaultRequestHeaders.Clear();
                            Form1.httpClient.DefaultRequestHeaders.Add("Authorization", token.Trim());
                            var response = await Form1.httpClient.PostAsync($"https://discord.com/api/v10/invites/{inviteCode}", null);
                            
                            if (response.IsSuccessStatusCode)
                            {
                                successCount++;
                            }
                            else
                            {
                                failCount++;
                            }

                            await client.StopAsync();
                        }

                        await Task.Delay(1000); // Rate limiting between joins
                    }
                    catch
                    {
                        failCount++;
                    }
                }

                lblBulkJoinStatus.Text = $"Bulk join complete: {successCount} joined, {failCount} failed";
                lblBulkJoinStatus.ForeColor = successCount > 0 ? System.Drawing.Color.Green : System.Drawing.Color.Red;
            }
            catch (Exception ex)
            {
                lblBulkJoinStatus.Text = $"Bulk join failed: {ex.Message}";
                lblBulkJoinStatus.ForeColor = System.Drawing.Color.Red;
            }
            finally
            {
                btnBulkJoin.Enabled = true;
            }
        }

        private async void btnSendMessage_Click(object sender, EventArgs e)
        {
            if (_client == null || _client.ConnectionState != ConnectionState.Connected)
            {
                lblMessageStatus.Text = "Please login first before sending messages.";
                lblMessageStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (_selectedUserId == null)
            {
                lblMessageStatus.Text = "Please select a user from the friends list.";
                lblMessageStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            string message = txtMessage.Text.Trim();

            if (string.IsNullOrEmpty(message))
            {
                lblMessageStatus.Text = "Please enter a message.";
                lblMessageStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            btnSendMessage.Enabled = false;
            lblMessageStatus.Text = "Sending message...";
            lblMessageStatus.ForeColor = System.Drawing.Color.Blue;

            try
            {
                // Create or get DM channel with the user
                var dmChannel = await _client.GetDMChannelAsync(_selectedUserId.Value);
                
                if (dmChannel == null)
                {
                    lblMessageStatus.Text = "Could not create DM channel.";
                    lblMessageStatus.ForeColor = System.Drawing.Color.Red;
                    btnSendMessage.Enabled = true;
                    return;
                }

                await dmChannel.SendMessageAsync(message);
                
                // Try to get the actual username if we only had the ID
                if (dmChannel.Recipients.Count > 0)
                {
                    var recipient = dmChannel.Recipients.First();
                    string actualName = $"{recipient.Username}#{recipient.Discriminator}";
                    if (_userCache[_selectedUserId.Value].StartsWith("User "))
                    {
                        _userCache[_selectedUserId.Value] = actualName;
                        // Update the listbox item
                        int index = lstUsers.Items.IndexOf($"User {_selectedUserId.Value}");
                        if (index >= 0)
                        {
                            lstUsers.Items[index] = actualName;
                        }
                        lblSelectedUser.Text = $"Chatting with: {actualName}";
                    }
                }
                
                // Add message to conversation display
                string currentUser = _client.CurrentUser?.Username ?? "You";
                rtbConversation.AppendText($"[{DateTime.Now:HH:mm}] {currentUser}: {message}\n");
                rtbConversation.ScrollToCaret();
                
                lblMessageStatus.Text = "Message sent successfully!";
                lblMessageStatus.ForeColor = System.Drawing.Color.Green;
                txtMessage.Text = ""; // Clear message after sending
            }
            catch (Exception ex)
            {
                lblMessageStatus.Text = $"Failed to send message: {ex.Message}";
                lblMessageStatus.ForeColor = System.Drawing.Color.Red;
            }
            finally
            {
                btnSendMessage.Enabled = true;
            }
        }

        private Task Log(LogMessage message)
        {
            return Task.CompletedTask;
        }

        protected override async void OnFormClosing(FormClosingEventArgs e)
        {
            if (_client != null)
            {
                try
                {
                    await _client.StopAsync();
                    _client.Dispose();
                }
                catch
                {
                    // Ignore errors during cleanup
                }
            }
            base.OnFormClosing(e);
        }
    }
}
