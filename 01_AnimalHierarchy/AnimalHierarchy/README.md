# AnimalHierarchy

## Description
A console application that demonstrates the use of **Inversion of Control (IoC)** and **Dependency Injection (DI)**. The project implements a hierarchy of animals where each animal has a name and the sound it makes. Outputs can be displayed in the console, saved to a file (`output.txt` in the root directory), or both simultaneously.

## Project Structure
```plaintext
AnimalHierarchy/
├── Interfaces/
│   ├── IAnimal.cs
│   └── IOutput.cs
├── Models/
│   ├── Dog.cs
│   └── Cat.cs
├── Services/
│   ├── CompositeOutput.cs
│   ├── ConsoleOutput.cs
│   └── FileOutput.cs
├── Program.cs
├── README.md
└── AnimalHierarchy.csproj
