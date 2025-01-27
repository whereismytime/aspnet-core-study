using System;
using System.Collections.Generic;
using NotesApp.Models;
using NotesApp.Views;

namespace NotesApp.Controllers
{
    /// <summary>
    /// Handles user interactions and note management.
    /// </summary>
    public class NotesController
    {
        private readonly NotesRepository _repository;
        private readonly ConsoleView _consoleView;

        public NotesController(NotesRepository repository, ConsoleView consoleView)
        {
            _repository = repository;
            _consoleView = consoleView;
        }

        public void AddNote(Note note)
        {
            var notes = _repository.LoadNotes("notes.json");
            notes.Add(note);
            _repository.SaveNotes(notes, "notes.json");
        }

        public void DisplayNotes()
        {
            var notes = _repository.LoadNotes("notes.json");
            _consoleView.DisplayAll(notes);
        }
    }
}
