using ChessModel;

namespace ChessGUI
{
    // Windows Form Application to display a chess board and the legal next moves of a selected piece and location
    public partial class Form1 : Form
    {

        static public Board board = new Board(8);
        private Button[,] btnBoard = new Button[board.size, board.size];
        private string piece;

        // constructor
        public Form1()
        {
            InitializeComponent();
            populateBtnBoard();
        }

        // button listener
        private void btnClick(object sender, EventArgs e)
        {
            clear();

            // get the selected row and column
            string[] tags = (sender as Button).Tag.ToString().Split("|");
            int row = int.Parse(tags[0]);
            int col = int.Parse(tags[1]);

            // set the selected cell as occupied
            Cell cur = board.at(row, col);
            cur.occupied = true;

            // mark all the legal moves and update the board display
            board.markLegalMoves(cur, piece);
            updateBtnBoard();
            (sender as Button).BackColor = Color.Cornsilk;
        }

        // clear the board display
        private void clear()
        {
            board.clear();
            for (int i = 0; i < board.size; i++)
            {
                for (int j = 0; j < board.size; j++)
                {
                    btnBoard[i, j].BackColor = default(Color);
                    btnBoard[i, j].Text = "";
                }
            }
        }

        // populate each button with its coordinates and hook up the button listener
        private void populateBtnBoard()
        {
            boardPanel.Height = boardPanel.Width;
            int btnSize = boardPanel.Width / board.size;

            for (int i = 0; i < board.size; i++)
            {
                for (int j = 0; j < board.size; j++)
                {
                    Button btn = new Button();
                    btn.Width = btnSize;
                    btn.Height = btnSize;
                    btn.Click += btnClick;
                    btn.Location = new Point(btnSize * i, btnSize * j);
                    btn.Tag = i + "|" + j;
                    boardPanel.Controls.Add(btn);
                    btnBoard[i, j] = btn;
                }
            }
        }

        // update the board display using the underlying board object
        private void updateBtnBoard()
        {
            for (int i = 0; i < board.size; i++)
            {
                for (int j = 0; j < board.size; j++)
                {
                    if (board.at(i, j).occupied)
                    {
                        btnBoard[i, j].Text = piece;
                    }
                    else if (board.at(i, j).legalMove)
                    {
                        btnBoard[i, j].Text = "Legal";
                    }
                    else
                    {
                        btnBoard[i, j].Text = "";
                    }
                }
            }
        }

        // combo box listener
        private void pieceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            piece = pieceComboBox.SelectedItem.ToString();
            clear();
        }
    }
}