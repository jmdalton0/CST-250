using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class KnightTour
    {
        private int size = 0;
        private int[,] board = { };
        private int attemptedMoves = 0;

        public void solve(int size, int startX, int startY)
        {
            init(size);
            if (solveR(startX - 1, startY - 1, 0))
            {
                print();
                Console.WriteLine("Total attempted moves: {0}", attemptedMoves);
            }
            else
            {
                Console.WriteLine("Solution does not exist starting from {0}, {1}", startX, startY);
            }
        }

        private bool solveR(int x, int y, int len)
        {
            if (size < 1)
            {
                return false;
            }
            len++;
            attemptedMoves++;
            board[x, y] = len;
            if (len == size * size)
            {
                return true;
            }

            List<Tuple<int, int>> moves = newMoves();
            while (moves.Count > 0)
            {
                int leastValidMovesInd = getLeastValidMovesInd(x, y, moves);
                int nextX = x + moves.ElementAt(leastValidMovesInd).Item1;
                int nextY = y + moves.ElementAt(leastValidMovesInd).Item2;
                if (safe(nextX, nextY) && solveR(nextX, nextY, len))
                {
                    return true;
                }
                else
                {
                    moves.Remove(moves.ElementAt(leastValidMovesInd));
                }
            }
            board[x, y] = -1;
            return false;
        }

        private bool safe(int x, int y)
        {
            return x >= 0 && x < size && y >= 0 && y < size && board[x, y] == -1;
        }

        private int getLeastValidMovesInd(int x, int y, List<Tuple<int, int>>moves)
        {
            int leastValidMoves = 9;
            int leastValidMovesInd = 0;
            for (int i = 0; i < moves.Count; i++)
            {
                int nextX = x + moves.ElementAt(i).Item1;
                int nextY = y + moves.ElementAt(i).Item2;
                if (safe(nextX, nextY))
                {
                    int numValidMoves = countValidMoves(nextX, nextY);
                    if (numValidMoves < leastValidMoves)
                    {
                        leastValidMoves = numValidMoves;
                        leastValidMovesInd = i;
                    }
                }
            }
            return leastValidMovesInd;
        }

        private int countValidMoves(int x, int y)
        {
            List<Tuple<int, int>> moves = newMoves();
            int count = 0;
            for (int i = 0; i < moves.Count; i++)
            {
                int nextX = x + moves.ElementAt(i).Item1;
                int nextY = y + moves.ElementAt(i).Item2;
                if (safe(nextX, nextY))
                {
                    count++;
                }
            }
            return count;
        }

        private void init(int size)
        {
            this.size = size;
            board = new int[size, size];
            attemptedMoves = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    board[i, j] = -1;
                }
            }
        }

        private List<Tuple<int, int>> newMoves()
        {
            List<Tuple<int, int>> moves = new List<Tuple<int, int>>
            {
                Tuple.Create(1, 2),
                Tuple.Create(1, -2),
                Tuple.Create(-1, 2),
                Tuple.Create(-1, -2),
                Tuple.Create(2, 1),
                Tuple.Create(2, -1),
                Tuple.Create(-2, 1),
                Tuple.Create(-2, -1)
            };
            return moves;
        }

        private void print()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
