using System.Collections.Generic;
using System.IO;
using NotesApp.Models;

namespace NotesApp.Views
{
    /// <summary>
    /// Saves notes to a file.
    /// </summary>
    public class FileView
    {
        private readonly string _filePath;

        public FileView(string filePath)
        {
            _filePath = filePath;
        }

        public void Save(Note note)
        {
            File.AppendAllText(_filePath, note.ToString() + "\n\n");
        }

        public void SaveAll(List<Note> notes)
        {
            using var writer = new StreamWriter(_filePath, false);
            foreach (var note in notes)
            {
                writer.WriteLine(note.ToString());
                writer.WriteLine("-------------");
            }
        }
    }
}
