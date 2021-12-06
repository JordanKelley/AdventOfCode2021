using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021.Domain
{
    public class OxygenGenerator
    {
        private List<string> diagnostics;

        public OxygenGenerator(List<string> diagnostics)
        {
            this.diagnostics = diagnostics;
        }

        public int Calculate()
        {
            var diagnosticsRemaining = new List<string>(this.diagnostics);

            for (var i = 0; i < diagnostics[0].Length; i++)
            {
                if (diagnosticsRemaining.Count == 1)
                {
                    break;
                }

                if (IndexHasEqualOrMoreOnes(i, diagnosticsRemaining))
                {
                    diagnosticsRemaining = diagnosticsRemaining.Where(x => x[i] == '1').ToList();
                }
                else
                {
                    diagnosticsRemaining = diagnosticsRemaining.Where(x => x[i] == '0').ToList();
                }
            }

            return Convert.ToInt32(diagnosticsRemaining[0], 2);
        }

        private bool IndexHasEqualOrMoreOnes(int index, List<string> diagnosticsRemaining)
        {
            var zeroCount = 0;
            var oneCount = 0;

            foreach (var diagnostic in diagnosticsRemaining)
            {
                if (diagnostic[index] == '1')
                {
                    oneCount++;
                }
                else 
                {
                    zeroCount++;
                }
            }

            return oneCount >= zeroCount;
        }
    }
}