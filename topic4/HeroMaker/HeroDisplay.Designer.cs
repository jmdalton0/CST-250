namespace HeroMaker
{
    partial class HeroDisplay
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
            heroListLabel = new Label();
            heroListBox = new ListBox();
            descriptionLabel = new Label();
            descriptionTextBox = new RichTextBox();
            addHeroButton = new Button();
            SuspendLayout();
            // 
            // heroListLabel
            // 
            heroListLabel.AutoSize = true;
            heroListLabel.Location = new Point(12, 9);
            heroListLabel.Name = "heroListLabel";
            heroListLabel.Size = new Size(56, 20);
            heroListLabel.TabIndex = 0;
            heroListLabel.Text = "Heroes";
            // 
            // heroListBox
            // 
            heroListBox.FormattingEnabled = true;
            heroListBox.ItemHeight = 20;
            heroListBox.Location = new Point(12, 32);
            heroListBox.Name = "heroListBox";
            heroListBox.Size = new Size(202, 364);
            heroListBox.TabIndex = 1;
            heroListBox.SelectedIndexChanged += heroListBox_Select;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(236, 9);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(85, 20);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(236, 32);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(552, 364);
            descriptionTextBox.TabIndex = 3;
            descriptionTextBox.Text = "";
            // 
            // addHeroButton
            // 
            addHeroButton.Location = new Point(12, 402);
            addHeroButton.Name = "addHeroButton";
            addHeroButton.Size = new Size(202, 39);
            addHeroButton.TabIndex = 4;
            addHeroButton.Text = "Add Hero";
            addHeroButton.UseVisualStyleBackColor = true;
            addHeroButton.Click += addHeroButton_Click;
            // 
            // HeroDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(addHeroButton);
            Controls.Add(descriptionTextBox);
            Controls.Add(descriptionLabel);
            Controls.Add(heroListBox);
            Controls.Add(heroListLabel);
            Name = "HeroDisplay";
            Text = "Hero Display";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label heroListLabel;
        private ListBox heroListBox;
        private Label descriptionLabel;
        private RichTextBox descriptionTextBox;
        private Button addHeroButton;
    }
}