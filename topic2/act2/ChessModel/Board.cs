using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessModel
{
    // represents all squares on the chess board held in a 2D array
    public class Board
    {
        // one square dimension of the board
        public int size { get; set; }

        // the underlying 2D array
        private Cell[,] grid;

        // constructor
        public Board(int size)
        {
            this.size = size;
            this.grid = new Cell[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    // initialize each element with a new Cell object
                    grid[i, j] = new Cell(i, j);
                }
            }
        }

        // access an element
        public Cell at(int x, int y)
        {
            if (exists(x, y))
            {
                return grid[x, y];
            }
            Console.WriteLine("Cell does not exist. Goodbye");
            System.Environment.Exit(1);
            return null;
        }

        // clear each cell on the board
        public void clear()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    grid[i, j].legalMove = false;
                    grid[i, j].occupied = false;
                }
            }
        }

        // set the legal attribute to true on each cell that is a next legal move from the currently occupied cell
        public void markLegalMoves(Cell cur, string piece)
        {
            switch (piece)
            {
                case "Knight": markLegalMovesKnight(cur);
                    break;
                case "Bishop": markLegalMovesBishop(cur);
                    break;
                case "Rook": markLegalMovesRook(cur);
                    break;
                case "Queen": markLegalMovesQueen(cur);
                    break;
                case "King": markLegalMovesKing(cur);
                    break;
            }
        }

        // check if the given x and y are a valid array index
        private bool exists(int x, int y)
        {
            if (
                x > -1 &&
                x < size &&
                y > -1 &&
                y < size
            )
            {
                return true;
            }
            return false;
        }

        // mark next legal moves for a knight
        private void markLegalMovesKnight(Cell cur)
        {
            // for -2, -1, 1, and 2 rows away
            for (int i = -2; i <= 2; i++)
            {
                if (i == 0) continue;
                // for negative and positive values
                for (int j = 0; j < 2; j++)
                {
                    int row = cur.row + i;
                    // the column will be 1 away if the row is 2 away and vice versa
                    int col = cur.col + ((i == 1 || i == -1 ? 2 : 1) * (j == 0 ? -1 : 1));

                    if (exists(row, col))
                    {
                        grid[row, col].legalMove = true;
                    }
                }
            }
        }

        // mark next legal moves for a bishop
        private void markLegalMovesBishop(Cell cur)
        {
            // for each diagonal extending from the current cell
            for (int i = 0; i < size; i++)
            {
                int row = cur.row + i;
                int col = cur.col + i;
                if (exists(row, col))
                {
                    grid[row, col].legalMove = true;
                }
                row = cur.row - i;
                col = cur.col - i;
                if (exists(row, col))
                {
                    grid[row, col].legalMove = true;
                }
                row = cur.row + i;
                col = cur.col - i;
                if (exists(row, col))
                {
                    grid[row, col].legalMove = true;
                }
                row = cur.row - i;
                col = cur.col + i;
                if (exists(row, col))
                {
                    grid[row, col].legalMove = true;
                }
            }
        }

        // mark next legal moves for a rook
        private void markLegalMovesRook(Cell cur)
        {
            // for each cell along the same row and column
            for (int i = 0; i < size; i++)
            {
                grid[i, cur.col].legalMove = true;
                grid[cur.row, i].legalMove = true;
            }
        }

        // mark next legal moves for a queen
        private void markLegalMovesQueen(Cell cur)
        {
            // bishop and rook combined
            markLegalMovesRook(cur);
            markLegalMovesBishop(cur);
        }

        // mark next legal moves for a king
        private void markLegalMovesKing(Cell cur)
        {
            // for each cell exactly 1 square away
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int row = cur.row + i;
                    int col = cur.col + j;
                    if (exists(row, col))
                    {
                        grid[row, col].legalMove = true;
                    }
                }
            }
        }
    }
}
