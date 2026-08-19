# Discord Multi-Tool

A comprehensive Discord utility application with multiple features for token management, messaging, server operations, and boosting. Built with C# and Discord.NET.

![Discord Multi-Tool](https://img.shields.io/badge/Discord-Multi--Tool-blue)
![C#](https://img.shields.io/badge/C%23-8.0-purple)
![Windows](https://img.shields.io/badge/Windows-Forms-green)

## 🚀 Features

### 🔐 Token Management
- **Token Validation**: Check if Discord tokens are valid and active
- **Verification Status**: Check phone verification status of accounts
- **Multi-Token Support**: Manage multiple tokens for different operations

### 💬 Messaging Tools
- **Message Center**: Send direct messages to users with a Discord-like interface
- **Bulk DM**: Send messages to multiple users at once
- **User Management**: Add users by ID and load friends from guilds
- **Conversation View**: Chat history with timestamps and user identification

### 🎯 Server Operations
- **Token Joiner**: Join Discord servers using tokens with invite codes
- **Bulk Joiner**: Join servers with multiple tokens simultaneously
- **Invite Parsing**: Supports multiple invite URL formats (discord.gg, discord.com/invite)

### ⚡ Server Boosting
- **Server Boost**: Boost servers using tokens with automatic captcha solving
- **Bulk Boost**: Boost servers with multiple tokens for maximum effect
- **2Captcha Integration**: Free captcha solving service integration

## 📋 Requirements

- Windows 10/11
- .NET 8.0 Runtime
- Discord Account with valid tokens
- 2Captcha API Key (for boost operations)

## 🔧 Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/Praydevs/Discord-Multi-Tool.git
   cd Discord-Multi-Tool
   ```

2. **Build the project**
   ```bash
   dotnet build
   ```

3. **Run the application**
   ```bash
   dotnet run
   ```

Or download the pre-built executable from the [Releases](https://github.com/Praydevs/Discord-Multi-Tool/releases) section.

## 📖 Usage Guide

### 🔑 Getting Started

1. **Launch the application**
2. **Enter your Discord token** in the login field
3. **Click "Check Token"** to validate the token
4. **Click "Login"** to connect to Discord

### 💬 Message Center

1. **Add users** to your contact list:
   - Users load automatically from your guilds
   - Or add users manually by ID
2. **Select a user** from the friends list
3. **Type your message** in the conversation area
4. **Click "Send"** to deliver the message

### 📨 Bulk DM

1. **Add users** to your contact list first
2. **Go to "Bulk DM" tab**
3. **Type your message** in the bulk message field
4. **Click "Send Bulk DM"** to message all users
5. **Monitor progress** with success/failure tracking

### 🎪 Token Joiner

1. **Go to "Token Joiner" tab**
2. **Enter server invite** (full URL or invite code)
3. **Enter Discord token** to use for joining
4. **Click "Join Server"** to join the server

### 📊 Bulk Joiner

1. **Go to "Bulk Joiner" tab**
2. **Enter server invite** (same for all tokens)
3. **Enter multiple tokens** (one per line)
4. **Click "Bulk Join"** to join with all tokens
5. **View results** with success/failure counts

### ⚡ Server Boost

1. **Get 2Captcha API Key**:
   - Visit https://2captcha.com
   - Register for a free account
   - Get your API key from the dashboard

2. **Configure Captcha**:
   - Go to "Settings" tab
   - Enter your 2Captcha API key
   - Save the configuration

3. **Boost Server**:
   - Go to "Server Boost" tab
   - Enter target server ID
   - Enter token to use for boosting
   - Click "Boost Server"
   - Wait for captcha solving and boost completion

### 🚀 Bulk Boost

1. **Configure 2Captcha** in Settings (if not done)
2. **Go to "Bulk Boost" tab**
3. **Enter target server ID**
4. **Enter multiple tokens** (one per line)
5. **Click "Bulk Boost"** to boost with all tokens
6. **Monitor progress** with detailed status updates

## ⚙️ Configuration

### Settings Tab
- **2Captcha API Key**: Required for boost operations
- **Auto-save**: Settings are preserved between sessions

### Token Security
- Tokens are masked in the UI (••••••••)
- Tokens are stored only in memory
- No token logging or persistence

## 🛡️ Safety Features

- **Rate Limiting**: Built-in delays between operations
- **Error Handling**: Graceful failure with clear messages
- **Captcha Solving**: Automatic bypass for boost operations
- **Connection Management**: Proper cleanup and resource management

## 📁 Project Structure

```
Discord-Multi-Tool/
├── wiwiwi/
│   ├── Form1.cs              # Main application logic
│   ├── Form1.Designer.cs     # UI design
│   ├── Program.cs            # Application entry point
│   └── wiwiwi.csproj        # Project configuration
├── README.md                 # This file
└── .gitignore               # Git ignore rules
```

## 🔧 Dependencies

- **Discord.NET** (3.20.1) - Discord API wrapper
- **System.Text.Json** (10.0.11) - JSON serialization
- **.NET 8.0** - Runtime framework

## ⚠️ Disclaimer

This tool is for educational purposes only. Use responsibly and in compliance with Discord's Terms of Service. The developers are not responsible for any misuse of this software.

- **Token Usage**: Only use tokens you have permission to use
- **Rate Limits**: Respect Discord's API rate limits
- **Server Rules**: Follow server rules when joining/boosting
- **Legal Compliance**: Ensure compliance with local laws and regulations

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📝 License

This project is licensed under the MIT License - see the LICENSE file for details.

## 👨‍💻 Author

**Praydevs**

- GitHub: [https://github.com/Praydevs](https://github.com/Praydevs)
- Project: [Discord Multi-Tool](https://github.com/Praydevs/Discord-Multi-Tool)

## 🙏 Acknowledgments

- Discord.NET team for the excellent API wrapper
- 2Captcha for captcha solving services
- The open-source community

## 📞 Support

If you encounter any issues or have questions:

1. Check the [Issues](https://github.com/Praydevs/Discord-Multi-Tool/issues) section
2. Create a new issue with detailed information
3. Join our Discord community (link coming soon)

## 🔮 Roadmap

- [ ] Add more captcha service options
- [ ] Implement proxy support
- [ ] Add scheduling for bulk operations
- [ ] Create web-based interface
- [ ] Add more server management features
- [ ] Implement account management tools

---

**Made with ❤️ by Praydevs**

*Discord Multi-Tool - Your all-in-one Discord utility solution*
See preview https://imgur.com/a/gGMawBM
