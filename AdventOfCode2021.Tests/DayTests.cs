using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using AdventOfCode2021.Days;

namespace AdventOfCode2021.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Day1Part1IsCorrect()
        {
            var expected = 1709;
            
            var result = Day1.Part1();

            Assert.Equals(expected, result);
        }
    }
}
