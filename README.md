# SwearJar-Bot
A simple Discord moderation bot built with C# that tracks how many times users swear in a server.  

This project is split into two main branches:

### 🧪 dev (logic branch)
- Core C# logic only
- Console-based testing
- No Discord integration
- Used for developing and debugging the swear detection system

### 🚀 main (production branch)
- Full Discord bot implementation
- Uses Discord.NET
- Real-time message tracking in servers
- Ready-to-use bot version

## ✨ Features

- 📊 Counts user swear words
- 👤 Tracks per-user statistics
- ⚡ Real-time message detection
- 🛡️ Custom swear word filtering
- 📁 Simple architecture
- 💬 Discord integration (main branch)

## Built With

- C#
- .NET
- Discord.NET


## 🚀 How to Run

### dev branch (console version)

```bash
git checkout dev
dotnet run
```

### main branch (Discord bot)

```bash
git checkout main
dotnet restore
dotnet run
```

---

## ⚙️ Configuration (main branch)

Create `appsettings.json`:

```json
{
  "Token": "YOUR_DISCORD_BOT_TOKEN"
}
```

---

## 📌 Future Improvements

- Leaderboard system
- Per-server settings
- Warning / mute system
- Web dashboard


## 👨‍💻 Developer

Created by **MCh27**  
Building systems that measure how toxic people can get in chat.
