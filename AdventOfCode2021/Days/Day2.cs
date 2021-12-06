using AdventOfCode2021.Domain;
using AdventOfCode2021.Domain.SubmarineStrategies;
using AdventOfCode2021.Services;

namespace AdventOfCode2021.Days
{
    public static class Day2
    {
        public static int Part1()
        {
            var instructions = PuzzleInputService.GetDay2Part1();
            var submarine = new Submarine(new InitialCommand(instructions));
            return submarine.Location;
        }

        public static int Part2()
        {
            var instructions = PuzzleInputService.GetDay2Part1();
            var submarine = new Submarine(new AimCommand(instructions));
            return submarine.Location;
        }
    }
}