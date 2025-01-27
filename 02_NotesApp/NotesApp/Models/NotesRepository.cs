using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace NotesApp.Models
{
    /// <summary>
    /// Handles saving and loading notes to and from files.
    /// </summary>
    public class NotesRepository
    {
        public void SaveNotes(List<Note> notes, string filePath)
        {
            var json = JsonSerializer.Serialize(notes, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public List<Note> LoadNotes(string filePath)
        {
            if (!File.Exists(filePath))
                return new List<Note>();

            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Note>>(json) ?? new List<Note>();
        }
    }
}
