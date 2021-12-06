using System;
using System.Collections.Generic;

namespace AdventOfCode2021.Domain
{
    public class EpsilonCalculator
    {
        private List<string> diagnostics;

        public EpsilonCalculator(List<string> diagnostics)
        {
            this.diagnostics = diagnostics;
        }

        public int Calculate()
        {
            var result = "";

            for (var i = 0; i < diagnostics[0].Length; i++)
            {
                var zeroCount = 0;
                var oneCount = 0;

                for (var j = 0; j < diagnostics.Count; j++)
                {
                    if (diagnostics[j][i] == '0')
                    {
                        zeroCount++;
                    }
                    else
                    {
                        oneCount++;
                    }
                }

                result += zeroCount > oneCount ? "1" : "0";
            }
            
            return Convert.ToInt32(result, 2);
        }
    }
}