using AdventOfCode2021.Domain;
using AdventOfCode2021.Services;

namespace AdventOfCode2021.Days
{
    public static class Day4
    {
        public static int Part1()
        {
            var data = PuzzleInputService.GetDay4BingoData();

            var game = new BingoGame(data);

            var winner = game.GetWinner();

            return winner.SumOfUnmarkedNumbers() * winner.LastNumberCalled;
        }
    }
}