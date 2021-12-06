using System.Collections.Generic;

using AdventOfCode2021.Domain;
using AdventOfCode2021.Services;

namespace AdventOfCode2021.Days
{
    public static class Day3
    {
        public static int Part1()
        {
            var diagnostics = PuzzleInputService.GetDay3Part1();

            var gammaCalculator = new GammaCalculator(diagnostics);
            var epsilonCalculator = new EpsilonCalculator(diagnostics);

            return gammaCalculator.Calculate() * epsilonCalculator.Calculate();
        }

        public static int Part2()
        {
            return 0;
        }
    }
}