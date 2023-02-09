using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeDemo
{
   public class TicTacToeDemo : ITicTacToe
    {
        public int GRID_SIZE = 5;
        public int[,] board;
        void Start()
        {
            board = new int[GRID_SIZE, GRID_SIZE];
        }
        public int PlacePiece(int row, int col, int player)
        {
            if (row + 2 < board.GetLength(0)
            && board[row + 1, col] + board[row + 2, col] + player == 3)
                return 1;
            if (row + 2 < board.GetLength(0)
                && board[row + 1, col] + board[row + 2, col] + player == -3)
                return 2;

            // line left
            if (row - 2 > 0
                && board[row - 1, col] + board[row - 2, col] + player == 3)
                return 1;
            if (row - 2 > 0
                && board[row - 1, col] + board[row - 2, col] + player == -3)
                return 2;

            // Diagonal ascending right
            if (row + 2 < board.GetLength(0) && col + 2 < board.GetLength(1)
                && board[row + 1, col + 1] + board[row + 2, col + 2] + player == 3)
                return 1;
            if (row + 2 < board.GetLength(0) && col + 2 < board.GetLength(1)
               && board[row + 1, col + 1] + board[row + 2, col + 2] + player == -3)
                return 2;

            return 0;
        }
    
    }
}
