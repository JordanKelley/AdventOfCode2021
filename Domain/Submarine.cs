using System;
using System.Collections.Generic;

using AdventOfCode2021.Domain.Enums;

namespace AdventOfCode2021.Domain
{
    public class Submarine
    {
        public int HorizontalPosition { get; private set; }
        public int Depth { get; private set; }
        private List<(string, int)> commands;

        public Submarine(List<(string, int)> commands)
        {
            this.commands = commands;
            this.ProcessCommands();
        }

        private void ProcessCommands()
        {
            foreach (var commandEntry in commands)
            {
                var command = Enum.Parse(typeof(Command), commandEntry.Item1);

                switch (command)
                {
                    case Command.down:
                    this.Depth += commandEntry.Item2;
                    break;
                    
                    case Command.forward:
                    this.HorizontalPosition += commandEntry.Item2;
                    break;

                    case Command.up:
                    this.Depth -= commandEntry.Item2;
                    break;
                }
                
            }
        }
    }
}