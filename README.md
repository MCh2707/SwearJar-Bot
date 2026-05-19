# SwearJar (Console Version)

A simple C# console application that detects and counts swear words from user input.  
This is the **core logic version** of the SwearJar project — no Discord integration, just pure backend logic testing.

This version is used to:
- Test swear word detection logic
- Track how many times a user uses profanity
- Validate core system before Discord bot integration


## 🛠️ Built With

- C#
- .NET Console Application

---

## 🚀 How to Run

Clone the repository:

```bash
git clone https://github.MCh2707/SwearJar.git
```

Go to the project folder:

```bash
cd SwearJar
```

Run the program:

```bash
dotnet run
```

---

## 💻 How It Works

The program:
1. Asks user for input
2. Checks text for banned words
3. Increases counter if swear words are found
4. Displays updated user statistics in console

Example:

```text
Enter message: hello bro
No swear words detected

Enter message: (bad word)
Swear detected! Total count: 1
```

## 📌 Notes

- This is a **logic-only version**
- No Discord bot features included
- Designed for testing and development purposes


Created by **MCh27**
