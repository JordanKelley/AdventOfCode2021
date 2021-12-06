using Microsoft.VisualStudio.TestTools.UnitTesting;

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

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Day1Part2IsCorrect()
        {
            var expected = 1761;
            
            var result = Day1.Part2();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Day2Part1IsCorrect()
        {
            var expected = 1989265;
            
            var result = Day2.Part1();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Day2Part2IsCorrect()
        {
            var expected = 2089174012;
            
            var result = Day2.Part2();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Day3Part1IsCorrect()
        { 
            var expected = 2261546;
            
            var result = Day3.Part1();

            Assert.AreEqual(expected, result);
        }
    }
}
