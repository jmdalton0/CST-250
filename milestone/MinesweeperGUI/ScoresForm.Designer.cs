namespace MinesweeperGUI
{
    partial class ScoresForm
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
            scoresList = new ListBox();
            doneButton = new Button();
            scoresLabel = new Label();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            saveButton = new Button();
            timeLabel = new Label();
            timeValueLabel = new Label();
            namePanel = new Panel();
            savedLabel = new Label();
            namePanel.SuspendLayout();
            SuspendLayout();
            // 
            // scoresList
            // 
            scoresList.FormattingEnabled = true;
            scoresList.ItemHeight = 20;
            scoresList.Location = new Point(12, 191);
            scoresList.Name = "scoresList";
            scoresList.Size = new Size(447, 184);
            scoresList.TabIndex = 0;
            // 
            // doneButton
            // 
            doneButton.Location = new Point(12, 381);
            doneButton.Name = "doneButton";
            doneButton.Size = new Size(447, 44);
            doneButton.TabIndex = 1;
            doneButton.Text = "Done";
            doneButton.UseVisualStyleBackColor = true;
            doneButton.Click += doneButton_Click;
            // 
            // scoresLabel
            // 
            scoresLabel.AutoSize = true;
            scoresLabel.Location = new Point(12, 168);
            scoresLabel.Name = "scoresLabel";
            scoresLabel.Size = new Size(183, 20);
            scoresLabel.TabIndex = 2;
            scoresLabel.Text = "Top 5 Best Times for level ";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(3, 57);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(123, 20);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Enter Your Name:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(132, 54);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(303, 27);
            nameTextBox.TabIndex = 4;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(312, 87);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(123, 44);
            saveButton.TabIndex = 5;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(3, 21);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(78, 20);
            timeLabel.TabIndex = 6;
            timeLabel.Text = "Your Time:";
            // 
            // timeValueLabel
            // 
            timeValueLabel.AutoSize = true;
            timeValueLabel.Location = new Point(391, 21);
            timeValueLabel.Name = "timeValueLabel";
            timeValueLabel.Size = new Size(44, 20);
            timeValueLabel.TabIndex = 7;
            timeValueLabel.Text = "00:00";
            // 
            // namePanel
            // 
            namePanel.Controls.Add(savedLabel);
            namePanel.Controls.Add(nameLabel);
            namePanel.Controls.Add(saveButton);
            namePanel.Controls.Add(timeLabel);
            namePanel.Controls.Add(nameTextBox);
            namePanel.Controls.Add(timeValueLabel);
            namePanel.Enabled = false;
            namePanel.Location = new Point(21, 9);
            namePanel.Name = "namePanel";
            namePanel.Size = new Size(438, 134);
            namePanel.TabIndex = 8;
            // 
            // savedLabel
            // 
            savedLabel.AutoSize = true;
            savedLabel.Location = new Point(3, 111);
            savedLabel.Name = "savedLabel";
            savedLabel.Size = new Size(0, 20);
            savedLabel.TabIndex = 8;
            // 
            // ScoresForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 437);
            Controls.Add(namePanel);
            Controls.Add(scoresLabel);
            Controls.Add(doneButton);
            Controls.Add(scoresList);
            Name = "ScoresForm";
            Text = "Best Times";
            namePanel.ResumeLayout(false);
            namePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox scoresList;
        private Button doneButton;
        private Label scoresLabel;
        private Label nameLabel;
        private TextBox nameTextBox;
        private Button saveButton;
        private Label timeLabel;
        private Label timeValueLabel;
        private Panel namePanel;
        private Label savedLabel;
    }
}