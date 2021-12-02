using System;
using AdventOfCode2021.Domain;
using AdventOfCode2021.Services;

namespace AdventOfCode2021.Days
{
    public static class Day2
    {
        public static void Part1()
        {
            var commands = PuzzleInputService.GetDay2Part1();
            var submarine = new Submarine(commands);
            Console.WriteLine(submarine.Depth * submarine.HorizontalPosition);
        }

        public static void Part2()
        {

        }
    }
}