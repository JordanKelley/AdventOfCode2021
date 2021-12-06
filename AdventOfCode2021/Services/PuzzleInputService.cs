using System.Collections.Generic;
using System.IO;

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
    }
}