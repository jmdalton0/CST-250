namespace MinesweeperGUI
{
    partial class MenuForm
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
            levelLabel = new Label();
            easyRadio = new RadioButton();
            mediumRadio = new RadioButton();
            difficultRadio = new RadioButton();
            playButton = new Button();
            SuspendLayout();
            // 
            // levelLabel
            // 
            levelLabel.AutoSize = true;
            levelLabel.Location = new Point(41, 37);
            levelLabel.Name = "levelLabel";
            levelLabel.Size = new Size(87, 20);
            levelLabel.TabIndex = 0;
            levelLabel.Text = "Select Level";
            // 
            // easyRadio
            // 
            easyRadio.AutoSize = true;
            easyRadio.Location = new Point(41, 87);
            easyRadio.Name = "easyRadio";
            easyRadio.Size = new Size(59, 24);
            easyRadio.TabIndex = 1;
            easyRadio.TabStop = true;
            easyRadio.Text = "Easy";
            easyRadio.UseVisualStyleBackColor = true;
            // 
            // mediumRadio
            // 
            mediumRadio.AutoSize = true;
            mediumRadio.Location = new Point(41, 117);
            mediumRadio.Name = "mediumRadio";
            mediumRadio.Size = new Size(85, 24);
            mediumRadio.TabIndex = 2;
            mediumRadio.TabStop = true;
            mediumRadio.Text = "Medium";
            mediumRadio.UseVisualStyleBackColor = true;
            // 
            // difficultRadio
            // 
            difficultRadio.AutoSize = true;
            difficultRadio.Location = new Point(41, 147);
            difficultRadio.Name = "difficultRadio";
            difficultRadio.Size = new Size(83, 24);
            difficultRadio.TabIndex = 3;
            difficultRadio.TabStop = true;
            difficultRadio.Text = "Difficult";
            difficultRadio.UseVisualStyleBackColor = true;
            // 
            // playButton
            // 
            playButton.BackColor = SystemColors.Control;
            playButton.Location = new Point(191, 127);
            playButton.Name = "playButton";
            playButton.Size = new Size(234, 44);
            playButton.TabIndex = 4;
            playButton.Text = "PLAY";
            playButton.UseVisualStyleBackColor = false;
            playButton.Click += playButton_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 205);
            Controls.Add(playButton);
            Controls.Add(difficultRadio);
            Controls.Add(mediumRadio);
            Controls.Add(easyRadio);
            Controls.Add(levelLabel);
            Name = "MenuForm";
            Text = "Minesweeper Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label levelLabel;
        private RadioButton easyRadio;
        private RadioButton mediumRadio;
        private RadioButton difficultRadio;
        private Button playButton;
    }
}