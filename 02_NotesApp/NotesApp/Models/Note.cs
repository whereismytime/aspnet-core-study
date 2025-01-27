using System;
using System.Collections.Generic;

namespace NotesApp.Models
{
    /// <summary>
    /// Represents a note with a title, content, creation date, and tags.
    /// </summary>
    public class Note
    {
        public string Title { get; set; } = string.Empty;   // Default value to avoid null warnings
        public string Content { get; set; } = string.Empty; // Default value to avoid null warnings
        public DateTime CreatedAt { get; set; }
        public List<string> Tags { get; set; }

        public Note()
        {
            Tags = new List<string>();
        }

        public override string ToString()
        {
            return $"Title: {Title}\nContent: {Content}\nCreated At: {CreatedAt}\nTags: {string.Join(", ", Tags)}";
        }
    }
}
