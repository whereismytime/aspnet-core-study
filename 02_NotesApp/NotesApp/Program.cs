using Microsoft.Extensions.DependencyInjection;
using NotesApp.Controllers;
using NotesApp.Models;
using NotesApp.Views;
using System;

namespace NotesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configure Dependency Injection
            var serviceProvider = new ServiceCollection()
                .AddSingleton<NotesRepository>()
                .AddSingleton<ConsoleView>()
                .AddSingleton<NotesController>()
                .BuildServiceProvider();

            var controller = serviceProvider.GetService<NotesController>();
            if (controller == null)
            {
                Console.WriteLine("Failed to resolve NotesController.");
                return;
            }

            Console.WriteLine("Adding a new note...");
            var note = new Note
            {
                Title = "Sample Note",
                Content = "This is a sample note.",
                CreatedAt = DateTime.Now,
                Tags = new List<string> { "Sample", "Note" }
            };

            controller.AddNote(note);
            controller.DisplayNotes();
        }
    }
}
