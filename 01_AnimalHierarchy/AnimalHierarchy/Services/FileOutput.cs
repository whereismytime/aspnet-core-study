using System;
using System.IO;

namespace AnimalHierarchy
{
    /// <summary>
    /// File-based implementation of the IOutput interface.
    /// Outputs messages to a specified file.
    /// </summary>
    public class FileOutput : IOutput
    {
        private readonly string _filePath; // Path to the output file

        public FileOutput(string filePath)
        {
            _filePath = filePath; // Initialize file path
        }

        public void Write(string message)
        {
            // Append message to the file with a newline
            File.AppendAllText(_filePath, message + Environment.NewLine);
        }
    }
}
