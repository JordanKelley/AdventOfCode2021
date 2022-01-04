using AdventOfCode2021.Domain;
using AdventOfCode2021.Services;

namespace AdventOfCode2021.Days
{
    public static class Day5
    {
        public static int Part1()
        {
            var lines = PuzzleInputService.GetDay5Part1();

            var grid = new Grid(lines);

            return grid.CalculatePointsOfOverlap();
        }

        public static int Part2()
        {
            var lines = PuzzleInputService.GetDay5Part1();

            var grid = new Grid(lines);

            return grid.CalculatePointsOfOverlap();
        }
    }
}