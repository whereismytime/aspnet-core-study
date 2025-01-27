# NotesApp

## Description
A console application for managing notes. Implements the MVC pattern with **Dependency Injection (DI)** using ASP.NET Core. Allows adding, saving, and loading notes from files.

---

## Features
1. Create and manage notes with:
   - Title
   - Content
   - Creation date
   - Tags
2. Save and load notes in JSON format.
3. Display notes in the console or save them to a file.

---

## File Structure
```plaintext
NotesApp/
├── Controllers/
│   ├── NotesController.cs
├── Models/
│   ├── Note.cs
│   ├── NotesRepository.cs
├── Views/
│   ├── ConsoleView.cs
│   ├── FileView.cs
├── notes.json
├── Program.cs
├── README.md
└── NotesApp.csproj
