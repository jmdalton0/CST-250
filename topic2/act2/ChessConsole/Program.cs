using ChessModel;

namespace ChessConsole
{
    // CLI driver program to read a starting square and piece from the user
    // output all legal next moves
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8);

            printBoard(board);

            Cell cur = setCell(board);
            string piece = setPiece();
            board.markLegalMoves(cur, piece);

            Console.WriteLine("Legal Moves:");
            printBoard(board);
        }

        // print method to display the board
        static private void printBoard(Board board)
        {
            for (int i = 0; i < board.size; i++)
            {
                for (int j = 0; j < board.size; j++)
                {
                    Console.Write("+---");
                }
                Console.WriteLine("+");
                for (int j = 0; j < board.size; j++)
                {
                    Console.Write("| ");
                    if (board.at(i, j).occupied)
                    {
                        Console.Write("X");
                    }
                    else if (board.at(i, j).legalMove)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    Console.Write(" ");
                }
                Console.WriteLine("|");
            }
            for (int j = 0; j < board.size; j++)
            {
                Console.Write("+---");
            }
            Console.WriteLine("+");
        }

        // input method to read an integer from the user: 0 <= input < max
        static private int getInt(string prompt, int max)
        {
            Console.Write(prompt + " > ");
            int input = 0;
            if (
                int.TryParse(Console.ReadLine(), out input) &&
                input > -1 &&
                input < max
            )
            {
                return input;
            }
            // if invalid, recursively prompt again
            return getInt(prompt, max);
        }

        // set the current cell using the user input
        static private Cell setCell(Board board)
        {
            int row = getInt("Row", board.size);
            int col = getInt("Col", board.size);

            Cell cur = board.at(row, col);
            cur.occupied = true;
            return cur;
        }

        // set the current piece using the user input
        static private string setPiece()
        {
            Console.Write("Piece > ");
            string piece = Console.ReadLine();
            switch (piece)
            {
                case "Knight": return piece;
                case "Bishop": return piece;
                case "Rook": return piece;
                case "Queen": return piece;
                case "King": return piece;
                // if invalid, recursively prompt again
                default: return setPiece();
            }
        }
    }
}