# 🪨📄✂️ Jokenpô — Tournament in C#

Rock-Paper-Scissors tournament game built in **C# with .NET 10**, used as a learning project for programming logic, object-oriented design, and full-stack evolution.

> 🌐 Versão em português: [README.pt-br.md](./README.pt-br.md)

---


## 📦 Latest Release

**Current Version:** **v0.1.0**

The first public release delivers the initial tournament engine for the project as a .NET console application.

### Release Highlights

- 🎮 Fully playable Rock–Paper–Scissors tournament
- 👥 User-defined number of participants
- 🏆 Automatic tournament progression until a single champion remains
- 💻 Console application built with C# and .NET
- 🚀 First official public release of the project

This version focuses on validating the game's core logic. Features such as a REST API, React front-end, persistent storage, and cloud deployment are planned for future releases.

📄 For complete release notes, see:

- [`Jokenpo/RELEASE_v0.1.0.md`](./Jokenpo/RELEASE_v0.1.0.md)


---

## 🗺️ Project Roadmap

```
Jokenpô
│
├── ✅ Phase 1 — Pure Logic (Console)
│   ├── ✅ Player input and creation
│   ├── ✅ Player count validation
│   ├── ✅ Automatic nickname generation
│   ├── ✅ Pairing players into duos
│   ├── ✅ Move validation and random move
│   ├── ✅ Move enum (Rock, Paper, Scissors)
│   ├── ✅ Tournament logic (in progress)
│   ├── ⏳ Tournament structure with Bye
│   ├── ✅ Matches between duos
│   ├── ⏳ Winners and losers list
│   ├── ✅ User-defined number of rounds
│   ├── ✅ Single-winner tournament system
│   └── ⏳ Menu customization
│
├── ⏳ Phase 2 — Object-Oriented Programming (OOP)
│   └── Full refactor with classes, inheritance, and encapsulation
│
├── ⏳ Phase 3 — Back-end API
│   └── Turn the game logic into a REST API with ASP.NET
│
├── ⏳ Phase 4 — Front-end
│   └── Separate web interface consuming the API
│
├── ⏳ Phase 5 — DevOps
│   └── Containerization with Docker and cloud deployment
│
└── ⏳ Phase 6 — Capstone Project
    └── Use as a college integrative project
```

> **Legend:** ✅ Done · 🔄 In progress · ⏳ Planned

---

## ✅ What's been built

- **Player input** — reads the number of participants via console
- **Automatic nickname creation** — generates identifiers like `Player 1`, `Player 2`, etc.
- **Count validation** — ensures a valid number of players for the tournament
- **Pairing into duos** — shuffles and organizes players into pairs for matches
- **Move validation** — checks whether the submitted move is valid
- **Random move** — automatically generates the computer's move or for absent players
- **Move enum** — represents the `Rock`, `Paper`, and `Scissors` options in a typed way
- **Tournament logic** — main game loop structure *(in progress)*
- **Full tournament system** — eliminate players until a single winner remains
- **Matches between duos** — running the rounds between the generated pairs
- **Number of rounds** — let the user define the number of rounds per match

---

## ⏳ What's left to build

- **Bye structure** — handling for when the number of players is odd
- **Winners and losers list** — score tracking and display per round
- **Menu customization** — improve the console interface with clearer options

---

## 🚀 Future Plans

| Phase | Description |
|------|-----------|
| 🎯 **OOP** | Refactor the project applying object-oriented pillars |
| 🌐 **REST API** | Turn the logic into an API with ASP.NET Core |
| 💻 **Front-end** | Build a separate web interface to consume the API |
| 🐳 **DevOps** | Containerize with Docker and deploy to the cloud |
| 🎓 **College** | Use as a capstone project for the CS degree |

---

## 🛠️ Tech Stack

- **C#** — Main language
- **.NET 10** — Development platform
- **Console App** — Current project interface

---

## 📁 Project Structure

```
Jokenpo/
├── Models/                 # Application domain classes
│   ├── GameMenu.cs         # Main game menu
│   ├── GetPlayers.cs       # Player registration/input
│   ├── PairsDraw.cs        # Match pairing draw
│   ├── Play.cs             # Match execution logic
│   └── Tournament.cs       # Tournament logic (rounds, bye, etc.)
├── Jokenpo.csproj          # Project configuration file (.NET)
├── Program.cs              # Application entry point
├── Jokenpo.slnx            # Solution file
├── .gitattributes          # Git attributes configuration
├── .gitignore               # Files/folders ignored by Git
├── README.md                # Documentation (English)
└── README.pt-br.md          # Documentation (Portuguese)
```

---

## ▶️ How to Run

```bash
# Clone the repository
git clone https://github.com/George-Abreu-git/Jokenpo.git
cd Jokenpo

# Run the project
dotnet run --project Jokenpo
```

> **Requirement:** .NET 10 SDK installed

---

## 👤 Author

**George Abreu**
[![GitHub](https://img.shields.io/badge/GitHub-George--Abreu--git-181717?style=flat&logo=github)](https://github.com/George-Abreu-git)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-Conectar-0077B5?style=flat&logo=linkedin)](https://linkedin.com/in/george-abreu-siqueira)