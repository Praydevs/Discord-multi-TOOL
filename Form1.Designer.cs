namespace wiwiwi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCheckToken = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.lblTokenStatus = new System.Windows.Forms.Label();
            this.lblVerificationStatus = new System.Windows.Forms.Label();
            this.grpLoginPanel = new System.Windows.Forms.GroupBox();
            this.lblGitHub = new System.Windows.Forms.LinkLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMessageCenter = new System.Windows.Forms.TabPage();
            this.tabBulkDM = new System.Windows.Forms.TabPage();
            this.tabTokenJoiner = new System.Windows.Forms.TabPage();
            this.tabBulkJoiner = new System.Windows.Forms.TabPage();
            this.tabBoost = new System.Windows.Forms.TabPage();
            this.tabBulkBoost = new System.Windows.Forms.TabPage();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.lblUsers = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.lblMessageStatus = new System.Windows.Forms.Label();
            this.rtbConversation = new System.Windows.Forms.RichTextBox();
            this.lblConversation = new System.Windows.Forms.Label();
            this.lblSelectedUser = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtBulkMessage = new System.Windows.Forms.TextBox();
            this.lblBulkMessage = new System.Windows.Forms.Label();
            this.btnBulkDM = new System.Windows.Forms.Button();
            this.lblBulkDMStatus = new System.Windows.Forms.Label();
            this.txtInvite = new System.Windows.Forms.TextBox();
            this.lblInvite = new System.Windows.Forms.Label();
            this.btnJoinServer = new System.Windows.Forms.Button();
            this.txtJoinToken = new System.Windows.Forms.TextBox();
            this.lblJoinToken = new System.Windows.Forms.Label();
            this.lblJoinStatus = new System.Windows.Forms.Label();
            this.txtBulkTokens = new System.Windows.Forms.TextBox();
            this.lblBulkTokens = new System.Windows.Forms.Label();
            this.btnBulkJoin = new System.Windows.Forms.Button();
            this.txtBulkInvite = new System.Windows.Forms.TextBox();
            this.lblBulkInvite = new System.Windows.Forms.Label();
            this.lblBulkJoinStatus = new System.Windows.Forms.Label();
            this.txtBoostServerId = new System.Windows.Forms.TextBox();
            this.lblBoostServerId = new System.Windows.Forms.Label();
            this.txtBoostToken = new System.Windows.Forms.TextBox();
            this.lblBoostToken = new System.Windows.Forms.Label();
            this.btnBoost = new System.Windows.Forms.Button();
            this.lblBoostStatus = new System.Windows.Forms.Label();
            this.txtBulkBoostServerId = new System.Windows.Forms.TextBox();
            this.lblBulkBoostServerId = new System.Windows.Forms.Label();
            this.txtBulkBoostTokens = new System.Windows.Forms.TextBox();
            this.lblBulkBoostTokens = new System.Windows.Forms.Label();
            this.btnBulkBoost = new System.Windows.Forms.Button();
            this.lblBulkBoostStatus = new System.Windows.Forms.Label();
            this.txtCaptchaApiKey = new System.Windows.Forms.TextBox();
            this.lblCaptchaApiKey = new System.Windows.Forms.Label();
            this.lblSettingsInfo = new System.Windows.Forms.Label();
            this.grpLoginPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabMessageCenter.SuspendLayout();
            this.tabBulkDM.SuspendLayout();
            this.tabTokenJoiner.SuspendLayout();
            this.tabBulkJoiner.SuspendLayout();
            this.tabBoost.SuspendLayout();
            this.tabBulkBoost.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblTitle.Location = new System.Drawing.Point(280, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(240, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Discord Multi-Tool";
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInstruction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblInstruction.Location = new System.Drawing.Point(200, 60);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(400, 20);
            this.lblInstruction.TabIndex = 1;
            this.lblInstruction.Text = "Enter your Discord token below to access all features:";
            // 
            // txtToken
            // 
            this.txtToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.txtToken.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtToken.ForeColor = System.Drawing.Color.White;
            this.txtToken.Location = new System.Drawing.Point(200, 85);
            this.txtToken.Name = "txtToken";
            this.txtToken.PasswordChar = '•';
            this.txtToken.Size = new System.Drawing.Size(400, 29);
            this.txtToken.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(250, 125);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 40);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCheckToken
            // 
            this.btnCheckToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(242)))), ((int)(((byte)(135)))));
            this.btnCheckToken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckToken.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheckToken.ForeColor = System.Drawing.Color.White;
            this.btnCheckToken.Location = new System.Drawing.Point(450, 125);
            this.btnCheckToken.Name = "btnCheckToken";
            this.btnCheckToken.Size = new System.Drawing.Size(150, 40);
            this.btnCheckToken.TabIndex = 4;
            this.btnCheckToken.Text = "Check Token";
            this.btnCheckToken.UseVisualStyleBackColor = false;
            this.btnCheckToken.Click += new System.EventHandler(this.btnCheckToken_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(200, 175);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 20);
            this.lblStatus.TabIndex = 5;
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserInfo.Location = new System.Drawing.Point(200, 200);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(0, 20);
            this.lblUserInfo.TabIndex = 6;
            // 
            // lblTokenStatus
            // 
            this.lblTokenStatus.AutoSize = true;
            this.lblTokenStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTokenStatus.Location = new System.Drawing.Point(200, 225);
            this.lblTokenStatus.Name = "lblTokenStatus";
            this.lblTokenStatus.Size = new System.Drawing.Size(0, 20);
            this.lblTokenStatus.TabIndex = 7;
            // 
            // lblVerificationStatus
            // 
            this.lblVerificationStatus.AutoSize = true;
            this.lblVerificationStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVerificationStatus.Location = new System.Drawing.Point(200, 250);
            this.lblVerificationStatus.Name = "lblVerificationStatus";
            this.lblVerificationStatus.Size = new System.Drawing.Size(0, 20);
            this.lblVerificationStatus.TabIndex = 8;
            // 
            // grpLoginPanel
            // 
            this.grpLoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.grpLoginPanel.Controls.Add(this.lblGitHub);
            this.grpLoginPanel.Controls.Add(this.lblVerificationStatus);
            this.grpLoginPanel.Controls.Add(this.lblTokenStatus);
            this.grpLoginPanel.Controls.Add(this.lblUserInfo);
            this.grpLoginPanel.Controls.Add(this.lblStatus);
            this.grpLoginPanel.Controls.Add(this.btnCheckToken);
            this.grpLoginPanel.Controls.Add(this.btnLogin);
            this.grpLoginPanel.Controls.Add(this.txtToken);
            this.grpLoginPanel.Controls.Add(this.lblInstruction);
            this.grpLoginPanel.Controls.Add(this.lblTitle);
            this.grpLoginPanel.ForeColor = System.Drawing.Color.White;
            this.grpLoginPanel.Location = new System.Drawing.Point(12, 12);
            this.grpLoginPanel.Name = "grpLoginPanel";
            this.grpLoginPanel.Size = new System.Drawing.Size(776, 280);
            this.grpLoginPanel.TabIndex = 9;
            this.grpLoginPanel.TabStop = false;
            this.grpLoginPanel.Text = "Login";
            // 
            // lblGitHub
            // 
            this.lblGitHub.AutoSize = true;
            this.lblGitHub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGitHub.Location = new System.Drawing.Point(650, 260);
            this.lblGitHub.Name = "lblGitHub";
            this.lblGitHub.Size = new System.Drawing.Size(120, 20);
            this.lblGitHub.TabIndex = 9;
            this.lblGitHub.TabStop = true;
            this.lblGitHub.Text = "github.com/Praydevs";
            this.lblGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGitHub_LinkClicked);
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.tabMessageCenter);
            this.tabControl.Controls.Add(this.tabBulkDM);
            this.tabControl.Controls.Add(this.tabTokenJoiner);
            this.tabControl.Controls.Add(this.tabBulkJoiner);
            this.tabControl.Controls.Add(this.tabBoost);
            this.tabControl.Controls.Add(this.tabBulkBoost);
            this.tabControl.Controls.Add(this.tabSettings);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl.Location = new System.Drawing.Point(12, 300);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 350);
            this.tabControl.TabIndex = 10;
            // 
            // tabMessageCenter
            // 
            this.tabMessageCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.tabMessageCenter.Controls.Add(this.lblSelectedUser);
            this.tabMessageCenter.Controls.Add(this.lblConversation);
            this.tabMessageCenter.Controls.Add(this.rtbConversation);
            this.tabMessageCenter.Controls.Add(this.lblMessageStatus);
            this.tabMessageCenter.Controls.Add(this.btnSendMessage);
            this.tabMessageCenter.Controls.Add(this.txtMessage);
            this.tabMessageCenter.Controls.Add(this.lblUsers);
            this.tabMessageCenter.Controls.Add(this.lstUsers);
            this.tabMessageCenter.Controls.Add(this.txtUserId);
            this.tabMessageCenter.Controls.Add(this.btnAddUser);
            this.tabMessageCenter.Controls.Add(this.lblUserId);
            this.tabMessageCenter.ForeColor = System.Drawing.Color.White;
            this.tabMessageCenter.Location = new System.Drawing.Point(4, 25);
            this.tabMessageCenter.Name = "tabMessageCenter";
            this.tabMessageCenter.Padding = new System.Windows.Forms.Padding(3);
            this.tabMessageCenter.Size = new System.Drawing.Size(768, 321);
            this.tabMessageCenter.TabIndex = 0;
            this.tabMessageCenter.Text = "Message Center";
            // 
            // tabBulkDM
            // 
            this.tabBulkDM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.tabBulkDM.Controls.Add(this.lblBulkDMStatus);
            this.tabBulkDM.Controls.Add(this.btnBulkDM);
            this.tabBulkDM.Controls.Add(this.txtBulkMessage);
            this.tabBulkDM.Controls.Add(this.lblBulkMessage);
            this.tabBulkDM.ForeColor = System.Drawing.Color.White;
            this.tabBulkDM.Location = new System.Drawing.Point(4, 25);
            this.tabBulkDM.Name = "tabBulkDM";
            this.tabBulkDM.Padding = new System.Windows.Forms.Padding(3);
            this.tabBulkDM.Size = new System.Drawing.Size(768, 321);
            this.tabBulkDM.TabIndex = 1;
            this.tabBulkDM.Text = "Bulk DM";
            // 
            // tabTokenJoiner
            // 
            this.tabTokenJoiner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.tabTokenJoiner.Controls.Add(this.lblJoinStatus);
            this.tabTokenJoiner.Controls.Add(this.btnJoinServer);
            this.tabTokenJoiner.Controls.Add(this.txtJoinToken);
            this.tabTokenJoiner.Controls.Add(this.lblJoinToken);
            this.tabTokenJoiner.Controls.Add(this.txtInvite);
            this.tabTokenJoiner.Controls.Add(this.lblInvite);
            this.tabTokenJoiner.ForeColor = System.Drawing.Color.White;
            this.tabTokenJoiner.Location = new System.Drawing.Point(4, 25);
            this.tabTokenJoiner.Name = "tabTokenJoiner";
            this.tabTokenJoiner.Padding = new System.Windows.Forms.Padding(3);
            this.tabTokenJoiner.Size = new System.Drawing.Size(768, 321);
            this.tabTokenJoiner.TabIndex = 2;
            this.tabTokenJoiner.Text = "Token Joiner";
            // 
            // tabBulkJoiner
            // 
            this.tabBulkJoiner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.tabBulkJoiner.Controls.Add(this.lblBulkJoinStatus);
            this.tabBulkJoiner.Controls.Add(this.btnBulkJoin);
            this.tabBulkJoiner.Controls.Add(this.txtBulkTokens);
            this.tabBulkJoiner.Controls.Add(this.lblBulkTokens);
            this.tabBulkJoiner.Controls.Add(this.txtBulkInvite);
            this.tabBulkJoiner.Controls.Add(this.lblBulkInvite);
            this.tabBulkJoiner.ForeColor = System.Drawing.Color.White;
            this.tabBulkJoiner.Location = new System.Drawing.Point(4, 25);
            this.tabBulkJoiner.Name = "tabBulkJoiner";
            this.tabBulkJoiner.Padding = new System.Windows.Forms.Padding(3);
            this.tabBulkJoiner.Size = new System.Drawing.Size(768, 321);
            this.tabBulkJoiner.TabIndex = 3;
            this.tabBulkJoiner.Text = "Bulk Joiner";
            // 
            // tabBoost
            // 
            this.tabBoost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.tabBoost.Controls.Add(this.lblBoostStatus);
            this.tabBoost.Controls.Add(this.btnBoost);
            this.tabBoost.Controls.Add(this.txtBoostToken);
            this.tabBoost.Controls.Add(this.lblBoostToken);
            this.tabBoost.Controls.Add(this.txtBoostServerId);
            this.tabBoost.Controls.Add(this.lblBoostServerId);
            this.tabBoost.ForeColor = System.Drawing.Color.White;
            this.tabBoost.Location = new System.Drawing.Point(4, 25);
            this.tabBoost.Name = "tabBoost";
            this.tabBoost.Padding = new System.Windows.Forms.Padding(3);
            this.tabBoost.Size = new System.Drawing.Size(768, 321);
            this.tabBoost.TabIndex = 4;
            this.tabBoost.Text = "Server Boost";
            // 
            // tabBulkBoost
            // 
            this.tabBulkBoost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.tabBulkBoost.Controls.Add(this.lblBulkBoostStatus);
            this.tabBulkBoost.Controls.Add(this.btnBulkBoost);
            this.tabBulkBoost.Controls.Add(this.txtBulkBoostTokens);
            this.tabBulkBoost.Controls.Add(this.lblBulkBoostTokens);
            this.tabBulkBoost.Controls.Add(this.txtBulkBoostServerId);
            this.tabBulkBoost.Controls.Add(this.lblBulkBoostServerId);
            this.tabBulkBoost.ForeColor = System.Drawing.Color.White;
            this.tabBulkBoost.Location = new System.Drawing.Point(4, 25);
            this.tabBulkBoost.Name = "tabBulkBoost";
            this.tabBulkBoost.Padding = new System.Windows.Forms.Padding(3);
            this.tabBulkBoost.Size = new System.Drawing.Size(768, 321);
            this.tabBulkBoost.TabIndex = 5;
            this.tabBulkBoost.Text = "Bulk Boost";
            // 
            // tabSettings
            // 
            this.tabSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.tabSettings.Controls.Add(this.lblSettingsInfo);
            this.tabSettings.Controls.Add(this.txtCaptchaApiKey);
            this.tabSettings.Controls.Add(this.lblCaptchaApiKey);
            this.tabSettings.ForeColor = System.Drawing.Color.White;
            this.tabSettings.Location = new System.Drawing.Point(4, 25);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(768, 321);
            this.tabSettings.TabIndex = 6;
            this.tabSettings.Text = "Settings";
            // 
            // lstUsers
            // 
            this.lstUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.lstUsers.ForeColor = System.Drawing.Color.White;
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.Location = new System.Drawing.Point(10, 45);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(200, 200);
            this.lstUsers.TabIndex = 0;
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsers.Location = new System.Drawing.Point(10, 20);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(80, 20);
            this.lblUsers.TabIndex = 1;
            this.lblUsers.Text = "Friends/DMs:";
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.txtMessage.ForeColor = System.Drawing.Color.White;
            this.txtMessage.Location = new System.Drawing.Point(220, 200);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(400, 40);
            this.txtMessage.TabIndex = 2;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.btnSendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSendMessage.ForeColor = System.Drawing.Color.White;
            this.btnSendMessage.Location = new System.Drawing.Point(630, 200);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(100, 40);
            this.btnSendMessage.TabIndex = 3;
            this.btnSendMessage.Text = "Send";
            this.btnSendMessage.UseVisualStyleBackColor = false;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // lblMessageStatus
            // 
            this.lblMessageStatus.AutoSize = true;
            this.lblMessageStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMessageStatus.Location = new System.Drawing.Point(220, 245);
            this.lblMessageStatus.Name = "lblMessageStatus";
            this.lblMessageStatus.Size = new System.Drawing.Size(0, 20);
            this.lblMessageStatus.TabIndex = 4;
            // 
            // rtbConversation
            // 
            this.rtbConversation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.rtbConversation.ForeColor = System.Drawing.Color.White;
            this.rtbConversation.Location = new System.Drawing.Point(220, 45);
            this.rtbConversation.Name = "rtbConversation";
            this.rtbConversation.ReadOnly = true;
            this.rtbConversation.Size = new System.Drawing.Size(510, 140);
            this.rtbConversation.TabIndex = 5;
            this.rtbConversation.Text = "";
            // 
            // lblConversation
            // 
            this.lblConversation.AutoSize = true;
            this.lblConversation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConversation.Location = new System.Drawing.Point(220, 20);
            this.lblConversation.Name = "lblConversation";
            this.lblConversation.Size = new System.Drawing.Size(90, 20);
            this.lblConversation.TabIndex = 6;
            this.lblConversation.Text = "Conversation:";
            // 
            // lblSelectedUser
            // 
            this.lblSelectedUser.AutoSize = true;
            this.lblSelectedUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedUser.Location = new System.Drawing.Point(320, 20);
            this.lblSelectedUser.Name = "lblSelectedUser";
            this.lblSelectedUser.Size = new System.Drawing.Size(0, 24);
            this.lblSelectedUser.TabIndex = 7;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserId.Location = new System.Drawing.Point(10, 255);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(70, 20);
            this.lblUserId.TabIndex = 8;
            this.lblUserId.Text = "User ID:";
            // 
            // txtUserId
            // 
            this.txtUserId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.txtUserId.ForeColor = System.Drawing.Color.White;
            this.txtUserId.Location = new System.Drawing.Point(90, 252);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(100, 29);
            this.txtUserId.TabIndex = 9;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(242)))), ((int)(((byte)(135)))));
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(200, 250);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(80, 35);
            this.btnAddUser.TabIndex = 10;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtBulkMessage
            // 
            this.txtBulkMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.txtBulkMessage.ForeColor = System.Drawing.Color.White;
            this.txtBulkMessage.Location = new System.Drawing.Point(10, 80);
            this.txtBulkMessage.Multiline = true;
            this.txtBulkMessage.Name = "txtBulkMessage";
            this.txtBulkMessage.Size = new System.Drawing.Size(500, 100);
            this.txtBulkMessage.TabIndex = 0;
            // 
            // lblBulkMessage
            // 
            this.lblBulkMessage.AutoSize = true;
            this.lblBulkMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBulkMessage.Location = new System.Drawing.Point(10, 55);
            this.lblBulkMessage.Name = "lblBulkMessage";
            this.lblBulkMessage.Size = new System.Drawing.Size(100, 20);
            this.lblBulkMessage.TabIndex = 1;
            this.lblBulkMessage.Text = "Bulk Message:";
            // 
            // btnBulkDM
            // 
            this.btnBulkDM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.btnBulkDM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBulkDM.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBulkDM.ForeColor = System.Drawing.Color.White;
            this.btnBulkDM.Location = new System.Drawing.Point(10, 190);
            this.btnBulkDM.Name = "btnBulkDM";
            this.btnBulkDM.Size = new System.Drawing.Size(150, 40);
            this.btnBulkDM.TabIndex = 2;
            this.btnBulkDM.Text = "Send Bulk DM";
            this.btnBulkDM.UseVisualStyleBackColor = false;
            this.btnBulkDM.Click += new System.EventHandler(this.btnBulkDM_Click);
            // 
            // lblBulkDMStatus
            // 
            this.lblBulkDMStatus.AutoSize = true;
            this.lblBulkDMStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBulkDMStatus.Location = new System.Drawing.Point(10, 240);
            this.lblBulkDMStatus.Name = "lblBulkDMStatus";
            this.lblBulkDMStatus.Size = new System.Drawing.Size(0, 20);
            this.lblBulkDMStatus.TabIndex = 3;
            // 
            // lblInvite
            // 
            this.lblInvite.AutoSize = true;
            this.lblInvite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInvite.Location = new System.Drawing.Point(10, 55);
            this.lblInvite.Name = "lblInvite";
            this.lblInvite.Size = new System.Drawing.Size(100, 20);
            this.lblInvite.TabIndex = 0;
            this.lblInvite.Text = "Server Invite:";
            // 
            // txtInvite
            // 
            this.txtInvite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.txtInvite.ForeColor = System.Drawing.Color.White;
            this.txtInvite.Location = new System.Drawing.Point(120, 52);
            this.txtInvite.Name = "txtInvite";
            this.txtInvite.Size = new System.Drawing.Size(300, 29);
            this.txtInvite.TabIndex = 1;
            // 
            // lblJoinToken
            // 
            this.lblJoinToken.AutoSize = true;
            this.lblJoinToken.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJoinToken.Location = new System.Drawing.Point(10, 100);
            this.lblJoinToken.Name = "lblJoinToken";
            this.lblJoinToken.Size = new System.Drawing.Size(80, 20);
            this.lblJoinToken.TabIndex = 2;
            this.lblJoinToken.Text = "Token:";
            // 
            // txtJoinToken
            // 
            this.txtJoinToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.txtJoinToken.ForeColor = System.Drawing.Color.White;
            this.txtJoinToken.Location = new System.Drawing.Point(120, 97);
            this.txtJoinToken.Name = "txtJoinToken";
            this.txtJoinToken.Size = new System.Drawing.Size(300, 29);
            this.txtJoinToken.TabIndex = 3;
            // 
            // btnJoinServer
            // 
            this.btnJoinServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.btnJoinServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoinServer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnJoinServer.ForeColor = System.Drawing.Color.White;
            this.btnJoinServer.Location = new System.Drawing.Point(10, 140);
            this.btnJoinServer.Name = "btnJoinServer";
            this.btnJoinServer.Size = new System.Drawing.Size(150, 40);
            this.btnJoinServer.TabIndex = 4;
            this.btnJoinServer.Text = "Join Server";
            this.btnJoinServer.UseVisualStyleBackColor = false;
            this.btnJoinServer.Click += new System.EventHandler(this.btnJoinServer_Click);
            // 
            // lblJoinStatus
            // 
            this.lblJoinStatus.AutoSize = true;
            this.lblJoinStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJoinStatus.Location = new System.Drawing.Point(10, 190);
            this.lblJoinStatus.Name = "lblJoinStatus";
            this.lblJoinStatus.Size = new System.Drawing.Size(0, 20);
            this.lblJoinStatus.TabIndex = 5;
            // 
            // lblBulkInvite
            // 
            this.lblBulkInvite.AutoSize = true;
            this.lblBulkInvite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBulkInvite.Location = new System.Drawing.Point(10, 55);
            this.lblBulkInvite.Name = "lblBulkInvite";
            this.lblBulkInvite.Size = new System.Drawing.Size(100, 20);
            this.lblBulkInvite.TabIndex = 0;
            this.lblBulkInvite.Text = "Server Invite:";
            // 
            // txtBulkInvite
            // 
            this.txtBulkInvite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.txtBulkInvite.ForeColor = System.Drawing.Color.White;
            this.txtBulkInvite.Location = new System.Drawing.Point(120, 52);
            this.txtBulkInvite.Name = "txtBulkInvite";
            this.txtBulkInvite.Size = new System.Drawing.Size(300, 29);
            this.txtBulkInvite.TabIndex = 1;
            // 
            // lblBulkTokens
            // 
            this.lblBulkTokens.AutoSize = true;
            this.lblBulkTokens.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBulkTokens.Location = new System.Drawing.Point(10, 100);
            this.lblBulkTokens.Name = "lblBulkTokens";
            this.lblBulkTokens.Size = new System.Drawing.Size(100, 20);
            this.lblBulkTokens.TabIndex = 2;
            this.lblBulkTokens.Text = "Tokens (one per line):";
            // 
            // txtBulkTokens
            // 
            this.txtBulkTokens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.txtBulkTokens.ForeColor = System.Drawing.Color.White;
            this.txtBulkTokens.Location = new System.Drawing.Point(120, 97);
            this.txtBulkTokens.Multiline = true;
            this.txtBulkTokens.Name = "txtBulkTokens";
            this.txtBulkTokens.Size = new System.Drawing.Size(300, 80);
            this.txtBulkTokens.TabIndex = 3;
            // 
            // btnBulkJoin
            // 
            this.btnBulkJoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.btnBulkJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBulkJoin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBulkJoin.ForeColor = System.Drawing.Color.White;
            this.btnBulkJoin.Location = new System.Drawing.Point(10, 190);
            this.btnBulkJoin.Name = "btnBulkJoin";
            this.btnBulkJoin.Size = new System.Drawing.Size(150, 40);
            this.btnBulkJoin.TabIndex = 4;
            this.btnBulkJoin.Text = "Bulk Join";
            this.btnBulkJoin.UseVisualStyleBackColor = false;
            this.btnBulkJoin.Click += new System.EventHandler(this.btnBulkJoin_Click);
            // 
            // lblBulkJoinStatus
            // 
            this.lblBulkJoinStatus.AutoSize = true;
            this.lblBulkJoinStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBulkJoinStatus.Location = new System.Drawing.Point(10, 240);
            this.lblBulkJoinStatus.Name = "lblBulkJoinStatus";
            this.lblBulkJoinStatus.Size = new System.Drawing.Size(0, 20);
            this.lblBulkJoinStatus.TabIndex = 5;
            // 
            // lblBoostServerId
            // 
            this.lblBoostServerId.AutoSize = true;
            this.lblBoostServerId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBoostServerId.Location = new System.Drawing.Point(10, 55);
            this.lblBoostServerId.Name = "lblBoostServerId";
            this.lblBoostServerId.Size = new System.Drawing.Size(100, 20);
            this.lblBoostServerId.TabIndex = 0;
            this.lblBoostServerId.Text = "Server ID:";
            // 
            // txtBoostServerId
            // 
            this.txtBoostServerId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.txtBoostServerId.ForeColor = System.Drawing.Color.White;
            this.txtBoostServerId.Location = new System.Drawing.Point(120, 52);
            this.txtBoostServerId.Name = "txtBoostServerId";
            this.txtBoostServerId.Size = new System.Drawing.Size(300, 29);
            this.txtBoostServerId.TabIndex = 1;
            // 
            // lblBoostToken
            // 
            this.lblBoostToken.AutoSize = true;
            this.lblBoostToken.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBoostToken.Location = new System.Drawing.Point(10, 100);
            this.lblBoostToken.Name = "lblBoostToken";
            this.lblBoostToken.Size = new System.Drawing.Size(80, 20);
            this.lblBoostToken.TabIndex = 2;
            this.lblBoostToken.Text = "Token:";
            // 
            // txtBoostToken
            // 
            this.txtBoostToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.txtBoostToken.ForeColor = System.Drawing.Color.White;
            this.txtBoostToken.Location = new System.Drawing.Point(120, 97);
            this.txtBoostToken.Name = "txtBoostToken";
            this.txtBoostToken.Size = new System.Drawing.Size(300, 29);
            this.txtBoostToken.TabIndex = 3;
            // 
            // btnBoost
            // 
            this.btnBoost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(66)))), ((int)(((byte)(69)))));
            this.btnBoost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoost.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBoost.ForeColor = System.Drawing.Color.White;
            this.btnBoost.Location = new System.Drawing.Point(10, 140);
            this.btnBoost.Name = "btnBoost";
            this.btnBoost.Size = new System.Drawing.Size(150, 40);
            this.btnBoost.TabIndex = 4;
            this.btnBoost.Text = "Boost Server";
            this.btnBoost.UseVisualStyleBackColor = false;
            this.btnBoost.Click += new System.EventHandler(this.btnBoost_Click);
            // 
            // lblBoostStatus
            // 
            this.lblBoostStatus.AutoSize = true;
            this.lblBoostStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBoostStatus.Location = new System.Drawing.Point(10, 190);
            this.lblBoostStatus.Name = "lblBoostStatus";
            this.lblBoostStatus.Size = new System.Drawing.Size(0, 20);
            this.lblBoostStatus.TabIndex = 5;
            // 
            // lblBulkBoostServerId
            // 
            this.lblBulkBoostServerId.AutoSize = true;
            this.lblBulkBoostServerId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBulkBoostServerId.Location = new System.Drawing.Point(10, 55);
            this.lblBulkBoostServerId.Name = "lblBulkBoostServerId";
            this.lblBulkBoostServerId.Size = new System.Drawing.Size(100, 20);
            this.lblBulkBoostServerId.TabIndex = 0;
            this.lblBulkBoostServerId.Text = "Server ID:";
            // 
            // txtBulkBoostServerId
            // 
            this.txtBulkBoostServerId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.txtBulkBoostServerId.ForeColor = System.Drawing.Color.White;
            this.txtBulkBoostServerId.Location = new System.Drawing.Point(120, 52);
            this.txtBulkBoostServerId.Name = "txtBulkBoostServerId";
            this.txtBulkBoostServerId.Size = new System.Drawing.Size(300, 29);
            this.txtBulkBoostServerId.TabIndex = 1;
            // 
            // lblBulkBoostTokens
            // 
            this.lblBulkBoostTokens.AutoSize = true;
            this.lblBulkBoostTokens.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBulkBoostTokens.Location = new System.Drawing.Point(10, 100);
            this.lblBulkBoostTokens.Name = "lblBulkBoostTokens";
            this.lblBulkBoostTokens.Size = new System.Drawing.Size(100, 20);
            this.lblBulkBoostTokens.TabIndex = 2;
            this.lblBulkBoostTokens.Text = "Tokens (one per line):";
            // 
            // txtBulkBoostTokens
            // 
            this.txtBulkBoostTokens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.txtBulkBoostTokens.ForeColor = System.Drawing.Color.White;
            this.txtBulkBoostTokens.Location = new System.Drawing.Point(120, 97);
            this.txtBulkBoostTokens.Multiline = true;
            this.txtBulkBoostTokens.Name = "txtBulkBoostTokens";
            this.txtBulkBoostTokens.Size = new System.Drawing.Size(300, 80);
            this.txtBulkBoostTokens.TabIndex = 3;
            // 
            // btnBulkBoost
            // 
            this.btnBulkBoost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(66)))), ((int)(((byte)(69)))));
            this.btnBulkBoost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBulkBoost.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBulkBoost.ForeColor = System.Drawing.Color.White;
            this.btnBulkBoost.Location = new System.Drawing.Point(10, 190);
            this.btnBulkBoost.Name = "btnBulkBoost";
            this.btnBulkBoost.Size = new System.Drawing.Size(150, 40);
            this.btnBulkBoost.TabIndex = 4;
            this.btnBulkBoost.Text = "Bulk Boost";
            this.btnBulkBoost.UseVisualStyleBackColor = false;
            this.btnBulkBoost.Click += new System.EventHandler(this.btnBulkBoost_Click);
            // 
            // lblBulkBoostStatus
            // 
            this.lblBulkBoostStatus.AutoSize = true;
            this.lblBulkBoostStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBulkBoostStatus.Location = new System.Drawing.Point(10, 240);
            this.lblBulkBoostStatus.Name = "lblBulkBoostStatus";
            this.lblBulkBoostStatus.Size = new System.Drawing.Size(0, 20);
            this.lblBulkBoostStatus.TabIndex = 5;
            // 
            // lblCaptchaApiKey
            // 
            this.lblCaptchaApiKey.AutoSize = true;
            this.lblCaptchaApiKey.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptchaApiKey.Location = new System.Drawing.Point(10, 55);
            this.lblCaptchaApiKey.Name = "lblCaptchaApiKey";
            this.lblCaptchaApiKey.Size = new System.Drawing.Size(150, 20);
            this.lblCaptchaApiKey.TabIndex = 0;
            this.lblCaptchaApiKey.Text = "2Captcha API Key:";
            // 
            // txtCaptchaApiKey
            // 
            this.txtCaptchaApiKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.txtCaptchaApiKey.ForeColor = System.Drawing.Color.White;
            this.txtCaptchaApiKey.Location = new System.Drawing.Point(170, 52);
            this.txtCaptchaApiKey.Name = "txtCaptchaApiKey";
            this.txtCaptchaApiKey.Size = new System.Drawing.Size(300, 29);
            this.txtCaptchaApiKey.TabIndex = 1;
            // 
            // lblSettingsInfo
            // 
            this.lblSettingsInfo.AutoSize = true;
            this.lblSettingsInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSettingsInfo.Location = new System.Drawing.Point(10, 100);
            this.lblSettingsInfo.Name = "lblSettingsInfo";
            this.lblSettingsInfo.Size = new System.Drawing.Size(500, 60);
            this.lblSettingsInfo.TabIndex = 2;
            this.lblSettingsInfo.Text = "Enter your 2Captcha API key for boost operations.\r\nGet your free API key from: https://2captcha.com\r\nRequired for server boosting to bypass captchas.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(800, 680);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.grpLoginPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.Text = "Discord Multi-Tool - by Praydevs";
            this.grpLoginPanel.ResumeLayout(false);
            this.grpLoginPanel.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabMessageCenter.ResumeLayout(false);
            this.tabMessageCenter.PerformLayout();
            this.tabBulkDM.ResumeLayout(false);
            this.tabBulkDM.PerformLayout();
            this.tabTokenJoiner.ResumeLayout(false);
            this.tabTokenJoiner.PerformLayout();
            this.tabBulkJoiner.ResumeLayout(false);
            this.tabBulkJoiner.PerformLayout();
            this.tabBoost.ResumeLayout(false);
            this.tabBoost.PerformLayout();
            this.tabBulkBoost.ResumeLayout(false);
            this.tabBulkBoost.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCheckToken;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Label lblTokenStatus;
        private System.Windows.Forms.Label lblVerificationStatus;
        private System.Windows.Forms.GroupBox grpLoginPanel;
        private System.Windows.Forms.LinkLabel lblGitHub;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMessageCenter;
        private System.Windows.Forms.TabPage tabBulkDM;
        private System.Windows.Forms.TabPage tabTokenJoiner;
        private System.Windows.Forms.TabPage tabBulkJoiner;
        private System.Windows.Forms.TabPage tabBoost;
        private System.Windows.Forms.TabPage tabBulkBoost;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Label lblMessageStatus;
        private System.Windows.Forms.RichTextBox rtbConversation;
        private System.Windows.Forms.Label lblConversation;
        private System.Windows.Forms.Label lblSelectedUser;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtBulkMessage;
        private System.Windows.Forms.Label lblBulkMessage;
        private System.Windows.Forms.Button btnBulkDM;
        private System.Windows.Forms.Label lblBulkDMStatus;
        private System.Windows.Forms.TextBox txtInvite;
        private System.Windows.Forms.Label lblInvite;
        private System.Windows.Forms.Button btnJoinServer;
        private System.Windows.Forms.TextBox txtJoinToken;
        private System.Windows.Forms.Label lblJoinToken;
        private System.Windows.Forms.Label lblJoinStatus;
        private System.Windows.Forms.TextBox txtBulkTokens;
        private System.Windows.Forms.Label lblBulkTokens;
        private System.Windows.Forms.Button btnBulkJoin;
        private System.Windows.Forms.TextBox txtBulkInvite;
        private System.Windows.Forms.Label lblBulkInvite;
        private System.Windows.Forms.Label lblBulkJoinStatus;
        private System.Windows.Forms.TextBox txtBoostServerId;
        private System.Windows.Forms.Label lblBoostServerId;
        private System.Windows.Forms.TextBox txtBoostToken;
        private System.Windows.Forms.Label lblBoostToken;
        private System.Windows.Forms.Button btnBoost;
        private System.Windows.Forms.Label lblBoostStatus;
        private System.Windows.Forms.TextBox txtBulkBoostServerId;
        private System.Windows.Forms.Label lblBulkBoostServerId;
        private System.Windows.Forms.TextBox txtBulkBoostTokens;
        private System.Windows.Forms.Label lblBulkBoostTokens;
        private System.Windows.Forms.Button btnBulkBoost;
        private System.Windows.Forms.Label lblBulkBoostStatus;
        private System.Windows.Forms.TextBox txtCaptchaApiKey;
        private System.Windows.Forms.Label lblCaptchaApiKey;
        private System.Windows.Forms.Label lblSettingsInfo;
    }
}