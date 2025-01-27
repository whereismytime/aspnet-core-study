namespace AnimalHierarchy
{
    /// <summary>
    /// Implementation of the Dog class.
    /// Represents a Dog with its name and sound.
    /// </summary>
    public class Dog : IAnimal
    {
        public string Name => "Dog";      // Name of the animal
        public string Sound => "Woof!";  // Sound of the animal

        /// <summary>
        /// Displays the Dog's name and sound using the provided output.
        /// </summary>
        public void Display(IOutput output)
        {
            output.Write($"Animal: {Name}, Sound: {Sound}");
        }
    }
}
