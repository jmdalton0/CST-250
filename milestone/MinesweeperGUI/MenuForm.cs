using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MinesweeperModel;

namespace MinesweeperGUI
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Level level = Level.easy;
            if (easyRadio.Checked)
            {
                level = Level.easy;
            }
            else if (mediumRadio.Checked)
            {
                level = Level.medium;
            }
            else
            {
                level = Level.difficult;
            }

            GameForm gameForm = new GameForm(level);
            gameForm.ShowDialog();
        }
    }
}
