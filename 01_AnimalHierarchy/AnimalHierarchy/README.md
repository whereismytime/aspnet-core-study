# AnimalHierarchy

## Description
This project implements a hierarchy of animal classes using **Inversion of Control (IoC)** and **Dependency Injection (DI)** principles. Each animal class stores data for a specific animal, such as its name and the sound it makes. Output can be displayed in the console, written to a file, or both simultaneously.

---

## How to Enable Console and File Output Simultaneously
To output data both to the console and to a file, the `CompositeOutput` class is used. Update the dependency injection configuration in `Program.cs` as follows:

```csharp
.AddSingleton<IOutput>(provider => new CompositeOutput(new IOutput[]
{
    new ConsoleOutput(),           // Output to console
    new FileOutput("output.txt")   // Output to file
}))
