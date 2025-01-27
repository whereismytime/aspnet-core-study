using Microsoft.Extensions.DependencyInjection;
using System;

namespace AnimalHierarchy
{
    /// <summary>
    /// Entry point of the application.
    /// Configures Dependency Injection and executes the logic.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Configure Dependency Injection (DI)
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IOutput>(provider => new CompositeOutput(new IOutput[]
                {
                    new ConsoleOutput(),           // Output to console
                    new FileOutput("output.txt")   // Output to file
                }))
                .AddTransient<IAnimal, Dog>()           // Register the Dog class
                .AddTransient<IAnimal, Cat>()           // Register the Cat class
                .BuildServiceProvider();

            // Resolve services
            var animals = serviceProvider.GetServices<IAnimal>();
            var output = serviceProvider.GetService<IOutput>();

            // Display information about each animal
            foreach (var animal in animals)
            {
                animal.Display(output);
            }
        }
    }
}
