using System;

namespace AdventOfCode2021.Days
{
    public static class Day1
    {
        public static void Part1()
        {
            var measurements = PuzzleInputService.GetDay1Part1();

            var counter = new DepthCounter(measurements);

            Console.WriteLine(counter.CalculateDepthIncreases());
        }

        public static void Part2()
        {
            var measurements = PuzzleInputService.GetDay1Part2();

            var counter = new DepthCounter(measurements);

            Console.WriteLine(counter.CalculateThreeMeasurmentWindow());
        }
    }
}