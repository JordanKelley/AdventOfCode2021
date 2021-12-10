using System;
using System.Collections.Generic;
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

        public BingoBoard GetLastWinner()
        {
            var bingos = 0;
            var boardsWithBingo = new List<BingoBoard>();

            foreach (var number in data.NumbersCalled)
            {
                foreach (var board in data.Boards)
                {
                    board.CallNumber(number);

                    if (board.Bingo)
                    {
                        if (!boardsWithBingo.Contains(board))
                        {
                            bingos++;
                            boardsWithBingo.Add(board);
                        }
                    }

                    if (bingos == data.Boards.Count)
                    {
                        return board;
                    }
                }
            }

            throw new Exception("There was no bingo for remaining boards");
        }
    }
}