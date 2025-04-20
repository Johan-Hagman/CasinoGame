
```markdown
# 🎰 Console CasinoGame in C#

Welcome to **Console Casino** – a C# console game where you can try your luck at two classic casino games: **Slot Machine** and **Blackjack**!

## 🧾 Table of Contents
- [About the Game](#-about-the-game)
- [Features](#-features)
- [Installation](#-installation)
- [How to Play](#-how-to-play)
- [File Structure](#-file-structure)
- [Gameplay Example](#-gameplay-example)
- [Possible Improvements](#-possible-improvements)
- [License](#-license)

---

## 🎮 About the Game
You play as a casino guest starting with 50 kr. Choose between a classic slot machine or Blackjack. The goal is to win money — or just have fun!

## ✨ Features
- 🕹 Menu to select games
- 💸 Dynamic balance system
- 🎰 Slot Machine with random numbers and win combos
- 🃏 Blackjack with simple AI dealer and player choices (Hit/Stand)
- 🧠 Interface-based game architecture (IGame)
- 🔁 Game loop for replaying or switching games

## ⚙️ Installation
1. Clone or download the project:
   ```bash
   git clone https://github.com/Johan-Hagman/casino-console-game.git
   ```
2. Open the project in [JetBrains Rider](https://www.jetbrains.com/rider/) or any IDE that supports C#/.NET.

3. Make sure the project runs as a .NET Core Console Application.

## ▶️ How to Play
Click **Run** in Rider or run via terminal:

```bash
dotnet run
```

## 📁 File Structure
```text
.
├── Program.cs          // Entry point with game menu and selection
├── Player.cs           // Represents the player and their balance
├── IGame.cs            // Interface implemented by all games
├── SlotMachine.cs      // Slot machine implementation
└── Blackjack.cs        // Blackjack implementation
```

## 🎥 Gameplay Example

```text
🎰 Welcome to the Casino!
Enter your name: Alex

👋 Hello, Alex!
💰 Balance: 50 kr

🎮 Choose a game:
1. Slot Machine
2. Blackjack
Q. Quit
```

---

## 🏗️ Possible Improvements
- 🧾 Add player statistics and history
- 💳 Save players and results to file or database
- 🎨 Improve UI with colors/animations (e.g. with Spectre.Console)
- 🃏 Add more casino games!

## 📜 License
This project is free to use for educational and hobby purposes.

---

> Built with ❤️ and 🎲 by [Johan Hagman]
```
