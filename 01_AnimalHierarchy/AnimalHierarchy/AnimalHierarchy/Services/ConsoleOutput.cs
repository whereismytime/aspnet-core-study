using System;

namespace AnimalHierarchy
{
    /// <summary>
    /// Console-based implementation of the IOutput interface.
    /// Outputs messages to the console.
    /// </summary>
    public class ConsoleOutput : IOutput
    {
        public void Write(string message)
        {
            Console.WriteLine(message); // Display message in the console
        }
    }
}
