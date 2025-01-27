# NotesApp

## Description
A console application for managing notes. The project implements the **MVC pattern** with **Dependency Injection (DI)** using ASP.NET Core. It allows creating, saving, and loading notes from a JSON file (`notes.json` in the root directory).

## Project Structure
```plaintext
NotesApp/
├── Controllers/
│   ├── NotesController.cs
├── Models/
│   ├── Note.cs
│   ├── NotesRepository.cs
├── Views/
│   ├── ConsoleView.cs
│   └── FileView.cs
├── notes.json
├── Program.cs
├── README.md
└── NotesApp.csproj