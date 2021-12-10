using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021.Data
{
    public class BingoBoard
    {
        public bool Bingo;
        public int LastNumberCalled;
        private int[][] board;
        private int[][] marked;

        public BingoBoard(int[][] board)
        {
            this.board = board;

            this.marked = new int[5][];
            this.marked[0] = new int[5];
            this.marked[1] = new int[5];
            this.marked[2] = new int[5];
            this.marked[3] = new int[5];
            this.marked[4] = new int[5];
        }

        public void CallNumber(int number)
        {
            this.LastNumberCalled = number;

            for (var i = 0; i < 5; i++)
            {
                for (var j = 0; j < 5; j++)
                {
                    if (board[i][j] == number)
                    {
                        this.marked[i][j] = 1;
                        this.Bingo = HasBingo();
                    }
                }
            }
        }

        public int SumOfUnmarkedNumbers()
        {
            var unmarkedNumbers = new List<int>();

            for (var i = 0; i < 5; i++)
            {
                for (var j = 0; j < 5; j++)
                {
                    if (marked[i][j] == 0)
                    {
                        unmarkedNumbers.Add(board[i][j]);
                    }
                }
            }

            return unmarkedNumbers.Sum();
        }

        private bool HasBingo()
        {
            return HasHorizontalBingo() || HasVerticalBingo();
        }

        private bool HasHorizontalBingo()
        {
            for (var i = 0; i < 5; i++)
            {
                for (var j = 0; j < 5; j++)
                {
                    if (this.marked[i][j] == 0)
                    {
                        break;
                    }
                    else if (j == 4)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool HasVerticalBingo()
        {
            for (var i = 0; i < 5; i++)
            {
                for (var j = 0; j < 5; j++)
                {
                    if (this.marked[j][i] == 0)
                    {
                        break;
                    }
                    else if (j == 4)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}