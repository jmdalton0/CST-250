namespace ChessGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pieceLabel = new System.Windows.Forms.Label();
            this.pieceComboBox = new System.Windows.Forms.ComboBox();
            this.boardPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pieceLabel
            // 
            this.pieceLabel.AutoSize = true;
            this.pieceLabel.Location = new System.Drawing.Point(12, 20);
            this.pieceLabel.Name = "pieceLabel";
            this.pieceLabel.Size = new System.Drawing.Size(349, 20);
            this.pieceLabel.TabIndex = 0;
            this.pieceLabel.Text = "Select a chess piece, then click a square on the grid:";
            // 
            // pieceComboBox
            // 
            this.pieceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pieceComboBox.FormattingEnabled = true;
            this.pieceComboBox.Items.AddRange(new object[] {
            "Knight",
            "Bishop",
            "Rook",
            "Queen",
            "King"});
            this.pieceComboBox.Location = new System.Drawing.Point(367, 12);
            this.pieceComboBox.Name = "pieceComboBox";
            this.pieceComboBox.Size = new System.Drawing.Size(203, 28);
            this.pieceComboBox.TabIndex = 1;
            this.pieceComboBox.SelectedIndexChanged += new System.EventHandler(this.pieceComboBox_SelectedIndexChanged);
            // 
            // boardPanel
            // 
            this.boardPanel.Location = new System.Drawing.Point(12, 46);
            this.boardPanel.Name = "boardPanel";
            this.boardPanel.Size = new System.Drawing.Size(558, 495);
            this.boardPanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.boardPanel);
            this.Controls.Add(this.pieceComboBox);
            this.Controls.Add(this.pieceLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label pieceLabel;
        private ComboBox pieceComboBox;
        private Panel boardPanel;
    }
}