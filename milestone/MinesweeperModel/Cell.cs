using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperModel
{
    public class Cell
    {
        public int row { get; set; }
        public int col { get; set; }
        public Boolean visited { get; set; }
        public Boolean live { get; set; }
        public int numLiveNeighbors { get; set; }

        public Cell()
        {
            row = -1;
            col = -1;
            visited = false;
            live = false;
            numLiveNeighbors = 0;
        }

        public string toString()
        {
            if (!visited)
            {
                return "\u25A0";
            }
            else if (live)
            {
                return "*";
            }
            else if (numLiveNeighbors == 0)
            {
                return " ";
            }
            else {
                return numLiveNeighbors.ToString();
            }
        }
    }
}
