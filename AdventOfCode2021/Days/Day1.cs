using System;

using AdventOfCode2021.Domain;
using AdventOfCode2021.Services;

namespace AdventOfCode2021.Days
{
    public static class Day1
    {
        public static int Part1()
        {
            var measurements = PuzzleInputService.GetDay1Part1();

            var counter = new DepthCounter(measurements);

            return counter.CalculateDepthIncreases();
        }

        public static int Part2()
        {
            var measurements = PuzzleInputService.GetDay1Part2();

            var counter = new DepthCounter(measurements);

            return counter.CalculateThreeMeasurmentWindow();
        }
    }
}