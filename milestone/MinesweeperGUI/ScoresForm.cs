using MinesweeperModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinesweeperGUI
{
    public partial class ScoresForm : Form
    {
        private Score score;
        private ScoreController scoreController;

        public ScoresForm(Score score)
        {
            InitializeComponent();
            this.score = score;
            this.scoreController = new ScoreController();
            scoresLabel.Text += score.level.ToString();
            allowSave();
            updateList();
        }

        private void allowSave()
        {
            if (score.time != TimeSpan.Zero)
            {
                namePanel.Enabled = true;
                timeValueLabel.Text = score.time.ToString("mm\\:ss");
            }
        }

        private void updateList()
        {
            scoresList.Items.Clear();
            List<Score> scores = scoreController.filterScores(score.level);
            foreach (Score s in scores)
            {
                scoresList.Items.Add(s.toString());
            }
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveButton.Enabled = false;
            score.name = nameTextBox.Text;
            scoreController.save(score);
            savedLabel.Text = "Saved";
            updateList();
        }
    }
}
