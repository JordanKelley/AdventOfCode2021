using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode2021
{
    public static class PuzzleInputService
    {
        public static List<int> GetDay1Part1()
        {
            var testInput = new List<int>();

            using (var reader = new StreamReader("PuzzleInput\\Day1\\Part1.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var line = Int32.Parse(reader.ReadLine());
                    testInput.Add(line);
                }
            }

            return testInput;
        }

        public static List<int> GetDay1Part2()
        {
            return GetDay1Part1();
        }
    }
}