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

namespace StopWatch
{
    public partial class StopWatch : Form
    {
        private Random random;
        private Stopwatch stopwatch;

        public StopWatch()
        {
            InitializeComponent();
            random = new Random();
            stopwatch = new Stopwatch();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = stopwatch.Elapsed.ToString();
            if (random.Next(0, 10) < 5)
            {
                targetBtn.Left = random.Next(0, this.Width - targetBtn.Width);
                targetBtn.Top = random.Next(0, this.Height - targetBtn.Height);
                targetBtn.Visible = true;
            }
        }

        private void targetBtn_Click(object sender, EventArgs e)
        {
            targetBtn.Visible = false;
        }
    }
}
