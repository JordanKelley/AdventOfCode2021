using System.Collections.Generic;

namespace AdventOfCode2021.Data
{
    public class BingoData
    {
        public List<int> NumbersCalled { get; }
        public List<BingoBoard> Boards { get; }

        public BingoData(List<int> numbersCalled, List<BingoBoard> boards)
        {
            this.NumbersCalled = numbersCalled;
            this.Boards = boards;
        }
    }
}