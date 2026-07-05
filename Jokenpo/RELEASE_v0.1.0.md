# Jokenpo — v0.1.0 🎮✂️📄🪨
> 🌐 Versão em português: [RELEASE_v0.1.0.pt-br.md](./RELEASE_v0.1.0.pt-br.md)

First public release of **Jokenpo**, a Rock–Paper–Scissors tournament system developed in C#/.NET.

This is an initial release focused on validating the tournament logic through a console application. There is no graphical or web interface yet—the goal of this milestone is to have the game's core engine working end-to-end.

## ✅ Features included in this release

- Runs through the **command-line interface (CLI)**.
- Prompts the user to enter the **number of players** participating in the tournament.
- Executes the tournament and determines a winner.
- Displays the champion at the end, identified as **"Player N"** (where N is the player's number).

## 🔜 What's not included yet

To clearly define the scope of this first release:

- No graphical interface or front-end (CLI only).
- No custom player names (players are identified by number only).
- No data persistence (tournament history, scores, etc.).
- No REST API—the project currently runs locally as a console application.

These features are part of the project's roadmap and will be implemented in future releases as development progresses through the following phases:

1. ✅ Console-based tournament logic (this release)
2. Object-Oriented Programming refactoring
3. REST API implementation
4. React front-end
5. Containerization and deployment

## 💻 How to run

This release includes builds for different environments.

### Windows (recommended — .NET not required)

A **self-contained** build that already includes the .NET runtime.

1. Download and extract the `net10.0/win-x64/publish/` folder.
2. Run `Jokenpo.exe`.

### Windows / Linux (requires .NET 10 Runtime)

A **framework-dependent** build with a smaller size, which requires the **.NET 10 Runtime** to be installed.

1. Download the `net10.0/publish/` folder.
2. Run:
   - Linux: `./Jokenpo`
   - Windows: `dotnet Jokenpo.dll`

### Requirements

| Build | Requirement |
|---|---|
| `win-x64/publish` | None (self-contained) |
| `net10.0/publish` | .NET 10 Runtime installed |

## 📌 Notes

This is a development release (v0.1.0) intended to document the project's progress and provide the foundation for future iterations. Feedback and suggestions are welcome through the repository's Issues.