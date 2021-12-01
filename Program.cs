using System;

namespace AdventOfCode2021
{
    class Program
    {
        static void Main(string[] args)
        {
            var measurements = PuzzleInputService.GetDay1Part1();

            var counter = new DepthCounter(measurements);

            Console.WriteLine(counter.CalculateDepthIncreases());
        }
    }
}
