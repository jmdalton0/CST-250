using MinesweeperModel;

namespace MinesweeperConsole
{
    class Program
    {
        const int SIZE = 12; // square dimensions of board
        const int DIFFICULTY = 10; // percentage of mines on board

        private static Board board;

        static void Main(string[] args)
        {

            Console.WriteLine("MINESWEEPER\n");

            board = new Board(SIZE);
            printBoard();

            // while the board still has live cells and the user has not selected a live cell
            bool done = false;
            while (!done)
            {

                // read next row and col from user, decrement for 0 indexing
                int row = getInt(board.size, "Row") - 1;
                int col = getInt(board.size, "Col") - 1;

                // update selected cell
                Cell cur = board.at(row, col);
                floodFill(row, col);

                // print board
                Console.WriteLine();
                printBoard();

                // display appropriate message
                // if user selected a bomb
                if (cur != null && cur.live)
                {
                    Console.WriteLine("YOU LOSE\n");
                    done = true;
                }
                // if all dead cells have been visited
                else if (board.cleared())
                {
                    Console.WriteLine("YOU WIN\n");
                    done = true;
                }
                else
                {
                    Console.WriteLine("CLEAR\n");
                }
            }

            Console.WriteLine("GAME OVER");
        }

        // helper method to read a valid integer from the user
        static private int getInt(int max, string prompt)
        {
            Console.Write(prompt + " > ");
            int input = 0;
            // while the input is not an integer, less than 0, or greater than the max
            while (
                !int.TryParse(Console.ReadLine(), out input ) ||
                input < 1 ||
                input > max
            )
            {
                // reprompt
                Console.Write(prompt + " > ");
            }
            return input;
        }

        // print the board
        static private void printBoard()
        {
            // col indeces
            Console.Write("   ");
            for (int i = 0; i < board.size; i++)
            {
                Console.Write(" " + string.Format("{0, 2}", (i + 1).ToString()) + " ");
            }
            Console.WriteLine("");

            // each row
            for (int i = 0; i < board.size; i++)
            {
                // cell boundaries
                Console.Write("   ");
                for (int j = 0; j < board.size; j++)
                {
                    Console.Write("+---");
                }
                Console.WriteLine("+");
                // row indeces
                Console.Write(string.Format("{0, -3}", (i + 1).ToString()));
                // each col
                for (int j = 0; j < board.size; j++)
                {
                    Console.Write("| " + board.at(i, j).toString() + " ");
                }
                Console.WriteLine("|");
            }
            // last cell boundaries
            Console.Write("   ");
            for (int j = 0; j < board.size; j++)
            {
                Console.Write("+---");
            }
            Console.WriteLine("+\n");
        }
    }
}