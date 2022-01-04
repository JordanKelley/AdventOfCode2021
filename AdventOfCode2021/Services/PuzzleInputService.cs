using System.Collections.Generic;
using System.IO;
using System.Linq;

using AdventOfCode2021.Data;

namespace AdventOfCode2021.Services
{
    public static class PuzzleInputService
    {
        public static List<int> GetDay1Part1()
        {
            var testInput = new List<int>();

            var directory = Directory.GetCurrentDirectory();

            using (var reader = new StreamReader(@"C:\Users\JMKELL\Documents\Repositories\AdventOfCode2021\AdventOfCode2021\PuzzleInput\Day1\Part1.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var line = int.Parse(reader.ReadLine());
                    testInput.Add(line);
                }
            }

            return testInput;
        }

        public static List<int> GetDay1Part2()
        {
            return GetDay1Part1();
        }

        public static List<(string, int)> GetDay2Part1()
        {
            var testInput = new List<(string, int)>();

            using (var reader = new StreamReader("C:\\Users\\JMKELL\\Documents\\Repositories\\AdventOfCode2021\\AdventOfCode2021\\PuzzleInput\\Day2\\Part1.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var lineSplit = reader.ReadLine().Split(" ");
                    var input = (lineSplit[0], int.Parse(lineSplit[1]));
                    testInput.Add(input);
                }
            }

            return testInput;
        }

        public static List<string> GetDay3Part1()
        {
            var testInput = new List<string>();

            using (var reader = new StreamReader("C:\\Users\\JMKELL\\Documents\\Repositories\\AdventOfCode2021\\AdventOfCode2021\\PuzzleInput\\Day3\\Part1.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var input = reader.ReadLine();
                    testInput.Add(input);
                }
            }

            return testInput;
        }

        public static BingoData GetDay4BingoData()
        {
            var numbers = new List<int>();
            var boards = new List<BingoBoard>();

            using (var reader = new StreamReader("C:\\Users\\JMKELL\\Documents\\Repositories\\AdventOfCode2021\\AdventOfCode2021\\PuzzleInput\\Day4\\Part1.txt"))
            {
                numbers = GetDay4BingoNumbers(reader);
                boards = GetDay4BingoBoards(reader);
            }

            return new BingoData(numbers, boards);
        }

        public static List<Line> GetDay5Part1()
        {
            var lines = new List<Line>();

            using (var reader = new StreamReader("C:\\Users\\JMKELL\\Documents\\Repositories\\AdventOfCode2021\\AdventOfCode2021\\PuzzleInput\\Day5\\Part1.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var input = reader.ReadLine().Replace(" -> ", ",").Split(",");
                    
                    var fromCoordinate = (int.Parse(input[0]), int.Parse(input[1]));
                    var toCoordinate = (int.Parse(input[2]), int.Parse(input[3]));
                    var line = new Line(fromCoordinate, toCoordinate);

                    lines.Add(line);
                }
            }

            return lines;

        }

        private static List<int> GetDay4BingoNumbers(StreamReader reader)
        {
            var numbers = new List<int>();

            var inputs = reader.ReadLine().Split(",");

            foreach (var input in inputs)
            {
                numbers.Add(int.Parse(input));
            }

            return numbers;
        }

        private static List<BingoBoard> GetDay4BingoBoards(StreamReader reader)
        {
            var boards = new List<BingoBoard>();

            while (!reader.EndOfStream)
            {
                var input = reader.ReadLine();

                if (input.Length != 0)
                {
                    var board = new int[5][];

                    for (var i = 0; i < 5; i++)
                    {
                        board[i] = GetRow(input);
                        input = reader.ReadLine();
                    }

                    boards.Add(new BingoBoard(board));
                }
            }

            return boards;
        }

        private static int[] GetRow(string input)
        {
            var row = new int[5];
            var count = 0;

            var nums = input.Split(" ").Where(x => !string.IsNullOrEmpty(x));

            foreach(var num in nums)
            {
                row[count] = int.Parse(num);

                count++;
            }

            return row;
        }
    }
}