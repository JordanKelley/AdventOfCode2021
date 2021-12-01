using System;
using System.Collections.Generic;

namespace AdventOfCode2021
{
    public class DepthCounter
    {
        private List<int> measurements;
        public DepthCounter(List<int> measurements)
        {
            this.measurements = measurements;
        }

        public int CalculateDepthIncreases()
        {
            var increases = 0;

            for (var i = 0; i < measurements.Count; i++)
            {
                if (i != 0 && measurements[i - 1] < measurements[i])
                {
                    increases++;
                }
            }

            return increases;
        }
    }
}