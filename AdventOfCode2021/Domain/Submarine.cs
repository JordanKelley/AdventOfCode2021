using AdventOfCode2021.Domain.SubmarineStrategies;

namespace AdventOfCode2021.Domain
{
    public class Submarine
    {
        public int Location { get; }

        public Submarine(SubmarineCommand command)
        {
            this.Location = command.ProcessLocation();
        }
    }
}