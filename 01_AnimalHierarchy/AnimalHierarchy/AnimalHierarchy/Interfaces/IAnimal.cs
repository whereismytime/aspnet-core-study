namespace AnimalHierarchy
{
    /// <summary>
    /// Interface for animal behavior.
    /// Provides properties for Name and Sound, and a method for displaying animal details.
    /// </summary>
    public interface IAnimal
    {
        string Name { get; }   // Name of the animal
        string Sound { get; }  // Sound of the animal

        void Display(IOutput output); // Method to display animal details using a specified output
    }
}
