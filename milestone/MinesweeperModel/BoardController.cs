using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperModel
{
    public enum Level
    {
        easy = 0,
        medium = 1,
        difficult = 2,
    }

    public class BoardController
    {
        private Board board;
        public Level level { get; }
        private int size;

        public BoardController(Level level)
        {
            this.level = level;
            size = level == Level.easy ? 5 : level == Level.medium ? 24 : 32;
            board = new Board(size);
        }

        public int getSize()
        {
            return size;
        }

        public bool isVisited(int row, int col)
        {
            return board.at(row, col).visited;
        }

        public bool isLive(int row, int col)
        {
            return board.at(row, col).live;
        }

        public int getNumLiveNeighborsAt(int row, int col)
        {
            return board.at(row, col).numLiveNeighbors;
        }

        public bool cleared()
        {
            return board.cleared();
        }

        public List<Tuple<int, int>> floodFill(int row, int col, List<Tuple<int, int>> visited)
        {
            Cell cur = board.at(row, col);
            if (cur == null || cur.visited)
            {
                return visited;
            }
            board.visit(row, col);
            visited.Add(new Tuple<int, int>(cur.row, cur.col));
            if (!cur.live && cur.numLiveNeighbors == 0)
            {
                floodFill(row, col + 1, visited);
                floodFill(row, col - 1, visited);
                floodFill(row + 1, col, visited);
                floodFill(row + 1, col + 1, visited);
                floodFill(row + 1, col - 1, visited);
                floodFill(row - 1, col, visited);
                floodFill(row - 1, col + 1, visited);
                floodFill(row - 1, col - 1, visited);
            }
            return visited;
        }
    }
}
