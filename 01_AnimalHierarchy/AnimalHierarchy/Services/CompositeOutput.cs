using System.Collections.Generic;

namespace AnimalHierarchy
{
    /// <summary>
    /// Combines multiple IOutput implementations to write to multiple destinations.
    /// </summary>
    public class CompositeOutput : IOutput
    {
        private readonly IEnumerable<IOutput> _outputs;

        public CompositeOutput(IEnumerable<IOutput> outputs)
        {
            _outputs = outputs;
        }

        public void Write(string message)
        {
            foreach (var output in _outputs)
            {
                output.Write(message);
            }
        }
    }
}
