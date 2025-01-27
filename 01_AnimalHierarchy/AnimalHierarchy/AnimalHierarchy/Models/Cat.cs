namespace AnimalHierarchy
{
    /// <summary>
    /// Implementation of the Cat class.
    /// Represents a Cat with its name and sound.
    /// </summary>
    public class Cat : IAnimal
    {
        public string Name => "Cat";      // Name of the animal
        public string Sound => "Meow!";  // Sound of the animal

        /// <summary>
        /// Displays the Cat's name and sound using the provided output.
        /// </summary>
        public void Display(IOutput output)
        {
            output.Write($"Animal: {Name}, Sound: {Sound}");
        }
    }
}
