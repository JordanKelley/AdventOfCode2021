using System;
using System.Collections.Generic;

using AdventOfCode2021.Domain.Enums;

namespace AdventOfCode2021.Domain.SubmarineStrategies
{
    public class AimCommand : SubmarineCommand
    {
        public AimCommand(List<(string, int)> commands) : base (commands)
        {

        }

        public override int ProcessLocation()
        {
            var depth = 0;
            var horizontalPosition = 0;
            var aim = 0;

            foreach (var instruction in this.instructions)
            {
                var command = Enum.Parse(typeof(Instruction), instruction.Item1);

                switch (command)
                {
                    case Instruction.down:
                    aim += instruction.Item2;
                    break;
                    
                    case Instruction.forward:
                    horizontalPosition += instruction.Item2;
                    depth += aim * instruction.Item2;
                    break;

                    case Instruction.up:
                    aim -= instruction.Item2;
                    break;
                }
            }
            return depth * horizontalPosition;
        }
    }
}