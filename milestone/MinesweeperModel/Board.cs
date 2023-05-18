using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperModel
{
    public class Board
    {
        private const int FREQ = 10;

        public int size { get; }
        private Cell[,] grid;
        private int numLiveCells;
        private int numVisited;

        public Board(int size)
        {
            this.size = size;
            this.grid = new Cell[size, size];
            this.numLiveCells = size * size * FREQ / 100;
            this.numVisited = 0;
            init();
        }

        public int visit(int row, int col)
        {
            Cell cell = at(row, col);
            if (cell.live)
            {
                return -1;
            }
            cell.visited = true;
            numVisited++;
            return cell.numLiveNeighbors;
        }

        public Cell at(int row, int col)
        {
            if (
                row < 0 ||
                row > size - 1 ||
                col < 0 ||
                col > size - 1
            )
            {
                return null;
            }
            return grid[row, col];
        }

        private void init()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Cell cell = new Cell();
                    cell.row = i;
                    cell.col = j;
                    grid[i, j] = cell;
                }
            }

            int numLiveCellsLeft = numLiveCells;
            Random rand = new Random();
            while (numLiveCellsLeft > 0)
            {
                int rRow = rand.Next(size);
                int rCol = rand.Next(size);
                if (!at(rRow, rCol).live)
                {
                    at(rRow, rCol).live = true;
                    numLiveCellsLeft--;
                }
            }

            calculateLiveNeighbors();
        }

        private void calculateLiveNeighbors()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (at(i, j).live)
                    {
                        int prevRow = i > 0 ? -1 : 0;
                        int prevCol = j > 0 ? -1 : 0;
                        int nextRow = i < size - 1 ? 1 : 0;
                        int nextCol = j < size - 1 ? 1 : 0;
                        for (int u = prevRow; u <= nextRow; u++)
                        {
                            for (int v = prevCol; v <= nextCol; v++)
                            {
                                at(i + u, j + v).numLiveNeighbors++;
                            }
                        }
                    }
                }
            }
        }

        public bool cleared()
        {
            return (size * size) - numVisited == numLiveCells;
        }
    }
}
