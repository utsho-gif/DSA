using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Solver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] board = new string[,]
             {
                { "5", "3", ".", ".", "7", ".", ".", ".", "." },
                { "6", ".", ".", "1", "9", "5", ".", ".", "." },
                { ".", "9", "8", ".", ".", ".", ".", "6", "." },
                { "8", ".", ".", ".", "6", ".", ".", ".", "3" },
                { "4", ".", ".", "8", ".", "3", ".", ".", "1" },
                { "7", ".", ".", ".", "2", ".", ".", ".", "6" },
                { ".", "6", ".", ".", ".", ".", "2", "8", "." },
                { ".", ".", ".", "4", "1", "9", ".", ".", "5" },
                { ".", ".", ".", ".", "8", ".", ".", "7", "9" }
             };

            if (Sudoku_Solver(board))
            {
                Console.WriteLine("Sudoku Solved");
                PrintBoard(board);
            }
            else
            {
                Console.WriteLine("Failed to solve");
            }
            
        }

        public static void PrintBoard(string[,] board)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    Console.Write(board[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        public static bool Sudoku_Solver(string[,] board)
        {
            bool isValid(int col, int row, string[,] brd, string num)
            {
                for(int x = 0; x < 9; x++)
                {
                    if (brd[x, col] == num || brd[row, x] == num)
                    {
                        return false;
                    }
                    var r = 3 * Math.Floor((decimal)row / 3) + Math.Floor((decimal)x / 3);
                    var c = 3 * Math.Floor((decimal)col / 3) + x % 3;

                    if (brd[(int)r, (int)c] == num)
                    {
                        return false;
                    }
                }
                return true;
            }

            bool Helper(string[,] brd)
            {
                for(int row = 0; row < 9; row++)
                {
                    for(int col = 0; col < 9; col++)
                    {
                        if(brd[row, col] == ".")
                        {
                            for(int i = 1; i <= 9; i++)
                            {
                                string character = i.ToString();

                                if(isValid(col, row, brd, character))
                                {
                                    brd[row, col] = character;

                                    if (Helper(brd))
                                    {
                                        return true;
                                    }
                                    brd[row, col] = ".";
                                }
                            }
                            return false;
                        }
                    }
                }
                return true;
            }
            return Helper(board);
        }
    }
}
