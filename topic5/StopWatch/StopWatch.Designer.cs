namespace StopWatch
{
    partial class StopWatch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timeLabel = new Label();
            startBtn = new Button();
            stopBtn = new Button();
            resetBtn = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            targetBtn = new Button();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.Location = new Point(12, 9);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(104, 38);
            timeLabel.TabIndex = 0;
            timeLabel.Text = "0:00:00";
            // 
            // startBtn
            // 
            startBtn.Location = new Point(12, 211);
            startBtn.Margin = new Padding(3, 4, 3, 4);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(94, 29);
            startBtn.TabIndex = 1;
            startBtn.Text = "START";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += startBtn_Click;
            // 
            // stopBtn
            // 
            stopBtn.Location = new Point(112, 211);
            stopBtn.Margin = new Padding(3, 4, 3, 4);
            stopBtn.Name = "stopBtn";
            stopBtn.Size = new Size(94, 29);
            stopBtn.TabIndex = 2;
            stopBtn.Text = "STOP";
            stopBtn.UseVisualStyleBackColor = true;
            stopBtn.Click += stopBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(212, 211);
            resetBtn.Margin = new Padding(3, 4, 3, 4);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(94, 29);
            resetBtn.TabIndex = 3;
            resetBtn.Text = "RESET";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // targetBtn
            // 
            targetBtn.Location = new Point(112, 125);
            targetBtn.Name = "targetBtn";
            targetBtn.Size = new Size(94, 29);
            targetBtn.TabIndex = 4;
            targetBtn.Text = "TARGET";
            targetBtn.UseVisualStyleBackColor = true;
            targetBtn.Click += targetBtn_Click;
            // 
            // StopWatch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 253);
            Controls.Add(targetBtn);
            Controls.Add(resetBtn);
            Controls.Add(stopBtn);
            Controls.Add(startBtn);
            Controls.Add(timeLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "StopWatch";
            Text = "Stop Watch";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeLabel;
        private Button startBtn;
        private Button stopBtn;
        private Button resetBtn;
        private System.Windows.Forms.Timer timer1;
        private Button targetBtn;
    }
}