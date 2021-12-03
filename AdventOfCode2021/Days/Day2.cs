using System;
using AdventOfCode2021.Domain;
using AdventOfCode2021.Domain.SubmarineStrategies;
using AdventOfCode2021.Services;

namespace AdventOfCode2021.Days
{
    public static class Day2
    {
        public static void Part1()
        {
            var instructions = PuzzleInputService.GetDay2Part1();
            var submarine = new Submarine(new InitialCommand(instructions));
            Console.WriteLine(submarine.Location);
        }

        public static void Part2()
        {
            var instructions = PuzzleInputService.GetDay2Part1();
            var submarine = new Submarine(new AimCommand(instructions));
            Console.WriteLine(submarine.Location);
        }
    }
}