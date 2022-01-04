using System;
using System.Collections.Generic;

using AdventOfCode2021.Data;

namespace AdventOfCode2021.Domain
{
    public class Grid
    {
        private List<Line> lines;
        private int[,] grid;
        public Grid(List<Line> lines)
        {
            this.lines = lines;
            this.grid = new int[1000, 1000];
        }

        public int CalculatePointsOfOverlap()
        {
            foreach (var line in lines)
            {
                ApplyLineToGrid(line);
            }

            var count = 0;

            for (var i = 0; i < 1000; i++)
            {
                for (var j = 0; j < 1000; j++)
                {
                    if (this.grid[i, j] > 1)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        private void ApplyLineToGrid(Line line)
        {
            if (line.IsHorizontal)
            {
                var begginningXCoordinate = Math.Min(line.FromCoordinate.Item1, line.ToCoordinate.Item1);
                var endXCoordinate = Math.Max(line.FromCoordinate.Item1, line.ToCoordinate.Item1);
                ApplyHorizontalLine(line.FromCoordinate.Item2, begginningXCoordinate, endXCoordinate);
            }
            else if (line.IsVertical)
            {
                var begginningYCoordinate = Math.Min(line.FromCoordinate.Item2, line.ToCoordinate.Item2);
                var endYCoordinate = Math.Max(line.FromCoordinate.Item2, line.ToCoordinate.Item2);
                ApplyVerticalLine(line.FromCoordinate.Item1, begginningYCoordinate, endYCoordinate);
            }
        }

        private void ApplyHorizontalLine(int yCoordinate, int beginningXCoordinate, int endXCoordinate)
        {
            while (beginningXCoordinate <= endXCoordinate)
            {
                this.grid[beginningXCoordinate, yCoordinate]++;
                beginningXCoordinate++;
            }
        }

        private void ApplyVerticalLine(int xCoordinate, int beginningYCoordinate, int endYCoordinate)
        {
            while (beginningYCoordinate <= endYCoordinate)
            {
                this.grid[xCoordinate, beginningYCoordinate]++;
                beginningYCoordinate++;
            }
        }
    }
}