using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MinesweeperModel;

namespace MinesweeperGUI
{
    public partial class GameForm : Form
    {
        private const int BTN_SIZE = 30;

        private BoardController boardController;
        private Button[,] grid;
        private Stopwatch stopwatch;

        public GameForm(Level level)
        {
            InitializeComponent();
            boardController = new BoardController(level);
            int size = boardController.getSize();
            grid = new Button[size, size];
            stopwatch = new Stopwatch();
            stopwatch.Start();
            init();
        }

        private void init()
        {
            int size = boardController.getSize();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Button button = new Button();
                    button.Width = BTN_SIZE;
                    button.Height = BTN_SIZE;
                    button.MouseDown += button_MouseDown;
                    button.Location = new Point(BTN_SIZE * j, BTN_SIZE * i);
                    button.Tag = ((size * i) + j).ToString();
                    this.Controls.Add(button);
                    grid[i, j] = button;
                }
            }
        }

        private void show(int row, int col, bool flag)
        {
            if (boardController.isLive(row, col))
            {
                if (flag)
                {
                    grid[row, col].BackColor = Color.Teal;
                }
                else
                {
                    grid[row, col].BackColor = Color.Red;
                }
            }
            else
            {
                grid[row, col].BackColor = Color.Gainsboro;
                int numLiveNeighbors = boardController.getNumLiveNeighborsAt(row, col);
                if (numLiveNeighbors > 0)
                {
                    grid[row, col].Text = numLiveNeighbors.ToString();
                }
            }
        }

        private void end(bool win)
        {
            stopwatch.Stop();
            int size = boardController.getSize();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    show(i, j, win);
                }
            }

            TimeSpan time = stopwatch.Elapsed;
            if (win)
            {
                MessageBox.Show("YOU WIN\nTime: " + stopwatch.Elapsed.ToString("mm\\:ss"));
            }
            else {
                time = TimeSpan.Zero;
                MessageBox.Show("GAME OVER");
            }

            Score score = new Score();
            score.time = time;
            score.level = boardController.level;
            ScoresForm scoresForm = new ScoresForm(score);
            scoresForm.ShowDialog();
            this.Close();
        }

        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            int size = boardController.getSize();
            int tag = int.Parse(button.Tag.ToString());
            int row = tag / size;
            int col = tag % size;
            
            if (boardController.isVisited(row, col))
            {
                return;
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (boardController.isLive(row, col))
                {
                    end(false);
                }
 
                List<Tuple<int, int>> visited = new List<Tuple<int, int>> ();
                boardController.floodFill(row, col, visited);

                foreach (Tuple<int, int> coord in visited)
                {
                    show(coord.Item1, coord.Item2, false);
                }
            }
            else
            {
                if (button.BackColor == Color.Silver)
                {
                    button.BackColor = Color.White;
                } else
                {
                    button.BackColor = Color.Silver;
                }
            }

            if (boardController.cleared())
            {
                end(true);
            }
        }

    }
}
