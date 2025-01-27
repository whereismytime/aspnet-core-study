using System;
using NotesApp.Models;

namespace NotesApp.Views
{
    /// <summary>
    /// Displays notes in the console.
    /// </summary>
    public class ConsoleView
    {
        public void Display(Note note)
        {
            Console.WriteLine(note.ToString());
        }

        public void DisplayAll(List<Note> notes)
        {
            foreach (var note in notes)
            {
                Console.WriteLine("-------------");
                Console.WriteLine(note.ToString());
            }
        }
    }
}
