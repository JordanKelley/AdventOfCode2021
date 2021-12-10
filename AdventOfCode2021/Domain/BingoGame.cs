using System;

using AdventOfCode2021.Data;

namespace AdventOfCode2021.Domain
{
    public class BingoGame
    {
        private BingoData data;

        public BingoGame(BingoData data)
        {
            this.data = data;
        }

        public BingoBoard GetWinner()
        {
            foreach (var number in data.NumbersCalled)
            {
                foreach (var board in data.Boards)
                {
                    board.CallNumber(number);

                    if (board.Bingo)
                    {
                        return board;
                    }
                }
            }

            throw new Exception("No bingos for given bingo boards");
        }
    }
}