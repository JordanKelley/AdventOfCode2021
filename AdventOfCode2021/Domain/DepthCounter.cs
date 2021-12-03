using System.Collections.Generic;

namespace AdventOfCode2021.Domain
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
            return CalculateIncreases(measurements);
        }

        public int CalculateThreeMeasurmentWindow()
        {
            var sums = new List<int>();

            for (var i = 0; i < measurements.Count; i++)
            {
                if (i + 3 > measurements.Count)
                {
                    break;
                }

                var sum = measurements[i] + measurements[i + 1] + measurements[i + 2];
                sums.Add(sum);
            }

            return CalculateIncreases(sums);
        }

        private int CalculateIncreases(List<int> measurements)
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