using System.Collections.Generic;

namespace AdventOfCode2021.Domain.SubmarineStrategies
{
    public abstract class SubmarineCommand
    {
        protected List<(string, int)> instructions;

        public SubmarineCommand(List<(string, int)> instructions)
        {
            this.instructions = instructions;
        }
        
        public abstract int ProcessLocation();
    }
}