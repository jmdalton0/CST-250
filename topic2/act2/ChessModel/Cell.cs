using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessModel
{
    // represents one square on the chess board
    public class Cell
    {
        // 0 indexed row coordinate
        public int row { get; set; }

        // 0 indexed column coordinate
        public int col { get; set; }
        
        // if the square is occupied by a piece
        public bool occupied { get; set; }

        // if the square represents a legal next move from the currently occupied square
        public bool legalMove { get; set; }

        // constructor
        public Cell(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
    }
}
