namespace TextFileDataAccessGUI
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
            firstNameLabel = new Label();
            firstNameTextBox = new TextBox();
            lastNameLabel = new Label();
            lastNameTextBox = new TextBox();
            instrumentTextBox = new TextBox();
            instrumentLabel = new Label();
            addButton = new Button();
            peopleList = new ListView();
            firstName = new ColumnHeader();
            lastName = new ColumnHeader();
            instrument = new ColumnHeader();
            saveButton = new Button();
            loadButton = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(12, 15);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(80, 20);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(98, 12);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(200, 27);
            firstNameTextBox.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(12, 48);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(79, 20);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Last Name";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(98, 45);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(200, 27);
            lastNameTextBox.TabIndex = 3;
            // 
            // instrumentTextBox
            // 
            instrumentTextBox.Location = new Point(98, 78);
            instrumentTextBox.Name = "instrumentTextBox";
            instrumentTextBox.Size = new Size(200, 27);
            instrumentTextBox.TabIndex = 5;
            // 
            // instrumentLabel
            // 
            instrumentLabel.AutoSize = true;
            instrumentLabel.Location = new Point(12, 81);
            instrumentLabel.Name = "instrumentLabel";
            instrumentLabel.Size = new Size(79, 20);
            instrumentLabel.TabIndex = 4;
            instrumentLabel.Text = "Instrument";
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 132);
            addButton.Name = "addButton";
            addButton.Size = new Size(286, 40);
            addButton.TabIndex = 6;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // peopleList
            // 
            peopleList.Columns.AddRange(new ColumnHeader[] { firstName, lastName, instrument });
            peopleList.Location = new Point(304, 12);
            peopleList.Name = "peopleList";
            peopleList.Size = new Size(0, 0);
            peopleList.TabIndex = 7;
            peopleList.UseCompatibleStateImageBehavior = false;
            // 
            // firstName
            // 
            firstName.Text = "First Name";
            firstName.Width = 100;
            // 
            // lastName
            // 
            lastName.Text = "Last Name";
            lastName.Width = 100;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(12, 398);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(286, 40);
            saveButton.TabIndex = 8;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // loadButton
            // 
            loadButton.Location = new Point(12, 352);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(286, 40);
            loadButton.TabIndex = 9;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(310, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(446, 424);
            listBox1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 450);
            Controls.Add(listBox1);
            Controls.Add(loadButton);
            Controls.Add(saveButton);
            Controls.Add(peopleList);
            Controls.Add(addButton);
            Controls.Add(instrumentTextBox);
            Controls.Add(instrumentLabel);
            Controls.Add(lastNameTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameTextBox);
            Controls.Add(firstNameLabel);
            Name = "Form1";
            Text = "Band Roster";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private TextBox firstNameTextBox;
        private Label lastNameLabel;
        private TextBox lastNameTextBox;
        private TextBox instrumentTextBox;
        private Label instrumentLabel;
        private Button addButton;
        private ListView peopleList;
        private Button saveButton;
        private Button loadButton;
        private ColumnHeader firstName;
        private ColumnHeader lastName;
        private ColumnHeader instrument;
        private ListBox listBox1;
    }
}