namespace HeroMaker
{
    partial class HeroMaker
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
            nameLabel = new Label();
            nameTextBox = new TextBox();
            powersGroupBox = new GroupBox();
            speedCheckBox = new CheckBox();
            laserVisionCheckBox = new CheckBox();
            telepathyCheckBox = new CheckBox();
            invisibilityCheckBox = new CheckBox();
            flightCheckBox = new CheckBox();
            strengthCheckBox = new CheckBox();
            datesGroupBox = new GroupBox();
            discoveryDatePicker = new DateTimePicker();
            discoveryLabel = new Label();
            birthdayLabel = new Label();
            birthdayDatePicker = new DateTimePicker();
            locationsGroupBox = new GroupBox();
            locationsListBox = new ListBox();
            vehicleGroupBox = new GroupBox();
            boatRadioButton = new RadioButton();
            bikeRadioButton = new RadioButton();
            carRadioButton = new RadioButton();
            jetRadioButton = new RadioButton();
            otherGroupBox = new GroupBox();
            braveryValueLabel = new Label();
            braveryTrackBar = new Label();
            braverySlider = new TrackBar();
            experienceNumUpDown = new NumericUpDown();
            experienceLabel = new Label();
            durabilityHScroll = new HScrollBar();
            durabilityLabel = new Label();
            statisticsGroupBox = new GroupBox();
            leadershipValueLabel = new Label();
            intelligenceValueLabel = new Label();
            durabilityValueLabel = new Label();
            leadershipHScroll = new HScrollBar();
            leadershipLabel = new Label();
            intelligenceHScroll = new HScrollBar();
            intelligenceLabel = new Label();
            createButton = new Button();
            colorGroupBox = new GroupBox();
            secondColorBox = new PictureBox();
            primaryColorBox = new PictureBox();
            secondColorLabel = new Label();
            primaryColorLabel = new Label();
            colorDialog = new ColorDialog();
            powersGroupBox.SuspendLayout();
            datesGroupBox.SuspendLayout();
            locationsGroupBox.SuspendLayout();
            vehicleGroupBox.SuspendLayout();
            otherGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)braverySlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)experienceNumUpDown).BeginInit();
            statisticsGroupBox.SuspendLayout();
            colorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)secondColorBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)primaryColorBox).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(95, 20);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Hero's Name";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(113, 12);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(392, 27);
            nameTextBox.TabIndex = 1;
            // 
            // powersGroupBox
            // 
            powersGroupBox.Controls.Add(speedCheckBox);
            powersGroupBox.Controls.Add(laserVisionCheckBox);
            powersGroupBox.Controls.Add(telepathyCheckBox);
            powersGroupBox.Controls.Add(invisibilityCheckBox);
            powersGroupBox.Controls.Add(flightCheckBox);
            powersGroupBox.Controls.Add(strengthCheckBox);
            powersGroupBox.Location = new Point(12, 45);
            powersGroupBox.Name = "powersGroupBox";
            powersGroupBox.Size = new Size(221, 135);
            powersGroupBox.TabIndex = 2;
            powersGroupBox.TabStop = false;
            powersGroupBox.Text = "Powers";
            // 
            // speedCheckBox
            // 
            speedCheckBox.AutoSize = true;
            speedCheckBox.Location = new Point(109, 26);
            speedCheckBox.Name = "speedCheckBox";
            speedCheckBox.Size = new Size(73, 24);
            speedCheckBox.TabIndex = 3;
            speedCheckBox.Text = "Speed";
            speedCheckBox.UseVisualStyleBackColor = true;
            // 
            // laserVisionCheckBox
            // 
            laserVisionCheckBox.AutoSize = true;
            laserVisionCheckBox.Location = new Point(109, 56);
            laserVisionCheckBox.Name = "laserVisionCheckBox";
            laserVisionCheckBox.Size = new Size(109, 24);
            laserVisionCheckBox.TabIndex = 3;
            laserVisionCheckBox.Text = "Laser Vision";
            laserVisionCheckBox.UseVisualStyleBackColor = true;
            // 
            // telepathyCheckBox
            // 
            telepathyCheckBox.AutoSize = true;
            telepathyCheckBox.Location = new Point(109, 86);
            telepathyCheckBox.Name = "telepathyCheckBox";
            telepathyCheckBox.Size = new Size(95, 24);
            telepathyCheckBox.TabIndex = 3;
            telepathyCheckBox.Text = "Telepathy";
            telepathyCheckBox.UseVisualStyleBackColor = true;
            // 
            // invisibilityCheckBox
            // 
            invisibilityCheckBox.AutoSize = true;
            invisibilityCheckBox.Location = new Point(6, 86);
            invisibilityCheckBox.Name = "invisibilityCheckBox";
            invisibilityCheckBox.Size = new Size(97, 24);
            invisibilityCheckBox.TabIndex = 2;
            invisibilityCheckBox.Text = "Invisibility";
            invisibilityCheckBox.UseVisualStyleBackColor = true;
            // 
            // flightCheckBox
            // 
            flightCheckBox.AutoSize = true;
            flightCheckBox.Location = new Point(6, 56);
            flightCheckBox.Name = "flightCheckBox";
            flightCheckBox.Size = new Size(68, 24);
            flightCheckBox.TabIndex = 1;
            flightCheckBox.Text = "Flight";
            flightCheckBox.UseVisualStyleBackColor = true;
            // 
            // strengthCheckBox
            // 
            strengthCheckBox.AutoSize = true;
            strengthCheckBox.Location = new Point(6, 26);
            strengthCheckBox.Name = "strengthCheckBox";
            strengthCheckBox.Size = new Size(87, 24);
            strengthCheckBox.TabIndex = 0;
            strengthCheckBox.Text = "Strength";
            strengthCheckBox.UseVisualStyleBackColor = true;
            // 
            // datesGroupBox
            // 
            datesGroupBox.Controls.Add(discoveryDatePicker);
            datesGroupBox.Controls.Add(discoveryLabel);
            datesGroupBox.Controls.Add(birthdayLabel);
            datesGroupBox.Controls.Add(birthdayDatePicker);
            datesGroupBox.Location = new Point(239, 45);
            datesGroupBox.Name = "datesGroupBox";
            datesGroupBox.Size = new Size(266, 135);
            datesGroupBox.TabIndex = 3;
            datesGroupBox.TabStop = false;
            datesGroupBox.Text = "Important Dates";
            // 
            // discoveryDatePicker
            // 
            discoveryDatePicker.Location = new Point(6, 99);
            discoveryDatePicker.Name = "discoveryDatePicker";
            discoveryDatePicker.Size = new Size(250, 27);
            discoveryDatePicker.TabIndex = 3;
            // 
            // discoveryLabel
            // 
            discoveryLabel.AutoSize = true;
            discoveryLabel.Location = new Point(6, 76);
            discoveryLabel.Name = "discoveryLabel";
            discoveryLabel.Size = new Size(141, 20);
            discoveryLabel.TabIndex = 2;
            discoveryLabel.Text = "Discovery of Powers";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new Point(6, 23);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new Size(64, 20);
            birthdayLabel.TabIndex = 1;
            birthdayLabel.Text = "Birthday";
            // 
            // birthdayDatePicker
            // 
            birthdayDatePicker.Location = new Point(6, 46);
            birthdayDatePicker.Name = "birthdayDatePicker";
            birthdayDatePicker.Size = new Size(250, 27);
            birthdayDatePicker.TabIndex = 0;
            // 
            // locationsGroupBox
            // 
            locationsGroupBox.Controls.Add(locationsListBox);
            locationsGroupBox.Location = new Point(18, 186);
            locationsGroupBox.Name = "locationsGroupBox";
            locationsGroupBox.Size = new Size(176, 177);
            locationsGroupBox.TabIndex = 4;
            locationsGroupBox.TabStop = false;
            locationsGroupBox.Text = "Locations";
            // 
            // locationsListBox
            // 
            locationsListBox.FormattingEnabled = true;
            locationsListBox.ItemHeight = 20;
            locationsListBox.Items.AddRange(new object[] { "New York", "Los Angeles", "Las Vegas", "Tokyo", "Singapore", "London", "Paris", "Rome", "Sydney", "Cairo" });
            locationsListBox.Location = new Point(6, 26);
            locationsListBox.Name = "locationsListBox";
            locationsListBox.SelectionMode = SelectionMode.MultiSimple;
            locationsListBox.Size = new Size(164, 144);
            locationsListBox.TabIndex = 0;
            // 
            // vehicleGroupBox
            // 
            vehicleGroupBox.Controls.Add(boatRadioButton);
            vehicleGroupBox.Controls.Add(bikeRadioButton);
            vehicleGroupBox.Controls.Add(carRadioButton);
            vehicleGroupBox.Controls.Add(jetRadioButton);
            vehicleGroupBox.Location = new Point(200, 186);
            vehicleGroupBox.Name = "vehicleGroupBox";
            vehicleGroupBox.Size = new Size(81, 177);
            vehicleGroupBox.TabIndex = 1;
            vehicleGroupBox.TabStop = false;
            vehicleGroupBox.Text = "Vehicle";
            // 
            // boatRadioButton
            // 
            boatRadioButton.AutoSize = true;
            boatRadioButton.Location = new Point(6, 116);
            boatRadioButton.Name = "boatRadioButton";
            boatRadioButton.Size = new Size(61, 24);
            boatRadioButton.TabIndex = 5;
            boatRadioButton.TabStop = true;
            boatRadioButton.Text = "Boat";
            boatRadioButton.UseVisualStyleBackColor = true;
            // 
            // bikeRadioButton
            // 
            bikeRadioButton.AutoSize = true;
            bikeRadioButton.Location = new Point(6, 86);
            bikeRadioButton.Name = "bikeRadioButton";
            bikeRadioButton.Size = new Size(58, 24);
            bikeRadioButton.TabIndex = 5;
            bikeRadioButton.TabStop = true;
            bikeRadioButton.Text = "Bike";
            bikeRadioButton.UseVisualStyleBackColor = true;
            // 
            // carRadioButton
            // 
            carRadioButton.AutoSize = true;
            carRadioButton.Location = new Point(6, 56);
            carRadioButton.Name = "carRadioButton";
            carRadioButton.Size = new Size(52, 24);
            carRadioButton.TabIndex = 1;
            carRadioButton.TabStop = true;
            carRadioButton.Text = "Car";
            carRadioButton.UseVisualStyleBackColor = true;
            // 
            // jetRadioButton
            // 
            jetRadioButton.AutoSize = true;
            jetRadioButton.Location = new Point(6, 26);
            jetRadioButton.Name = "jetRadioButton";
            jetRadioButton.Size = new Size(48, 24);
            jetRadioButton.TabIndex = 0;
            jetRadioButton.TabStop = true;
            jetRadioButton.Text = "Jet";
            jetRadioButton.UseVisualStyleBackColor = true;
            // 
            // otherGroupBox
            // 
            otherGroupBox.Controls.Add(braveryValueLabel);
            otherGroupBox.Controls.Add(braveryTrackBar);
            otherGroupBox.Controls.Add(braverySlider);
            otherGroupBox.Controls.Add(experienceNumUpDown);
            otherGroupBox.Controls.Add(experienceLabel);
            otherGroupBox.Location = new Point(287, 186);
            otherGroupBox.Name = "otherGroupBox";
            otherGroupBox.Size = new Size(218, 177);
            otherGroupBox.TabIndex = 5;
            otherGroupBox.TabStop = false;
            otherGroupBox.Text = "Other";
            // 
            // braveryValueLabel
            // 
            braveryValueLabel.AutoSize = true;
            braveryValueLabel.Location = new Point(194, 61);
            braveryValueLabel.Name = "braveryValueLabel";
            braveryValueLabel.Size = new Size(17, 20);
            braveryValueLabel.TabIndex = 14;
            braveryValueLabel.Text = "0";
            braveryValueLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // braveryTrackBar
            // 
            braveryTrackBar.AutoSize = true;
            braveryTrackBar.Location = new Point(6, 58);
            braveryTrackBar.Name = "braveryTrackBar";
            braveryTrackBar.Size = new Size(58, 20);
            braveryTrackBar.TabIndex = 8;
            braveryTrackBar.Text = "Bravery";
            // 
            // braverySlider
            // 
            braverySlider.Location = new Point(6, 84);
            braverySlider.Name = "braverySlider";
            braverySlider.Size = new Size(206, 56);
            braverySlider.TabIndex = 7;
            braverySlider.Scroll += braverySlider_Slide;
            // 
            // experienceNumUpDown
            // 
            experienceNumUpDown.Location = new Point(149, 21);
            experienceNumUpDown.Name = "experienceNumUpDown";
            experienceNumUpDown.Size = new Size(63, 27);
            experienceNumUpDown.TabIndex = 6;
            // 
            // experienceLabel
            // 
            experienceLabel.AutoSize = true;
            experienceLabel.Location = new Point(6, 23);
            experienceLabel.Name = "experienceLabel";
            experienceLabel.Size = new Size(137, 20);
            experienceLabel.TabIndex = 0;
            experienceLabel.Text = "Years of Experience";
            // 
            // durabilityHScroll
            // 
            durabilityHScroll.Location = new Point(3, 43);
            durabilityHScroll.Name = "durabilityHScroll";
            durabilityHScroll.Size = new Size(254, 26);
            durabilityHScroll.TabIndex = 1;
            durabilityHScroll.Scroll += statisticHScroll_Scroll;
            // 
            // durabilityLabel
            // 
            durabilityLabel.AutoSize = true;
            durabilityLabel.Location = new Point(6, 23);
            durabilityLabel.Name = "durabilityLabel";
            durabilityLabel.Size = new Size(74, 20);
            durabilityLabel.TabIndex = 6;
            durabilityLabel.Text = "Durability";
            // 
            // statisticsGroupBox
            // 
            statisticsGroupBox.Controls.Add(leadershipValueLabel);
            statisticsGroupBox.Controls.Add(intelligenceValueLabel);
            statisticsGroupBox.Controls.Add(durabilityValueLabel);
            statisticsGroupBox.Controls.Add(leadershipHScroll);
            statisticsGroupBox.Controls.Add(leadershipLabel);
            statisticsGroupBox.Controls.Add(intelligenceHScroll);
            statisticsGroupBox.Controls.Add(intelligenceLabel);
            statisticsGroupBox.Controls.Add(durabilityLabel);
            statisticsGroupBox.Controls.Add(durabilityHScroll);
            statisticsGroupBox.Location = new Point(18, 369);
            statisticsGroupBox.Name = "statisticsGroupBox";
            statisticsGroupBox.Size = new Size(263, 164);
            statisticsGroupBox.TabIndex = 7;
            statisticsGroupBox.TabStop = false;
            statisticsGroupBox.Text = "Statistics";
            // 
            // leadershipValueLabel
            // 
            leadershipValueLabel.AutoSize = true;
            leadershipValueLabel.Location = new Point(240, 115);
            leadershipValueLabel.Name = "leadershipValueLabel";
            leadershipValueLabel.Size = new Size(17, 20);
            leadershipValueLabel.TabIndex = 13;
            leadershipValueLabel.Text = "0";
            leadershipValueLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // intelligenceValueLabel
            // 
            intelligenceValueLabel.AutoSize = true;
            intelligenceValueLabel.Location = new Point(240, 69);
            intelligenceValueLabel.Name = "intelligenceValueLabel";
            intelligenceValueLabel.Size = new Size(17, 20);
            intelligenceValueLabel.TabIndex = 12;
            intelligenceValueLabel.Text = "0";
            intelligenceValueLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // durabilityValueLabel
            // 
            durabilityValueLabel.AutoSize = true;
            durabilityValueLabel.Location = new Point(240, 23);
            durabilityValueLabel.Name = "durabilityValueLabel";
            durabilityValueLabel.Size = new Size(17, 20);
            durabilityValueLabel.TabIndex = 11;
            durabilityValueLabel.Text = "0";
            durabilityValueLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // leadershipHScroll
            // 
            leadershipHScroll.Location = new Point(3, 135);
            leadershipHScroll.Name = "leadershipHScroll";
            leadershipHScroll.Size = new Size(254, 26);
            leadershipHScroll.TabIndex = 10;
            leadershipHScroll.Scroll += statisticHScroll_Scroll;
            // 
            // leadershipLabel
            // 
            leadershipLabel.AutoSize = true;
            leadershipLabel.Location = new Point(6, 115);
            leadershipLabel.Name = "leadershipLabel";
            leadershipLabel.Size = new Size(81, 20);
            leadershipLabel.TabIndex = 9;
            leadershipLabel.Text = "Leadership";
            // 
            // intelligenceHScroll
            // 
            intelligenceHScroll.Location = new Point(3, 89);
            intelligenceHScroll.Name = "intelligenceHScroll";
            intelligenceHScroll.Size = new Size(254, 26);
            intelligenceHScroll.TabIndex = 8;
            intelligenceHScroll.Scroll += statisticHScroll_Scroll;
            // 
            // intelligenceLabel
            // 
            intelligenceLabel.AutoSize = true;
            intelligenceLabel.Location = new Point(6, 69);
            intelligenceLabel.Name = "intelligenceLabel";
            intelligenceLabel.Size = new Size(86, 20);
            intelligenceLabel.TabIndex = 7;
            intelligenceLabel.Text = "Intelligence";
            // 
            // createButton
            // 
            createButton.Location = new Point(287, 495);
            createButton.Name = "createButton";
            createButton.Size = new Size(218, 38);
            createButton.TabIndex = 9;
            createButton.Text = "CREATE";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // colorGroupBox
            // 
            colorGroupBox.Controls.Add(secondColorBox);
            colorGroupBox.Controls.Add(primaryColorBox);
            colorGroupBox.Controls.Add(secondColorLabel);
            colorGroupBox.Controls.Add(primaryColorLabel);
            colorGroupBox.Location = new Point(287, 369);
            colorGroupBox.Name = "colorGroupBox";
            colorGroupBox.Size = new Size(218, 125);
            colorGroupBox.TabIndex = 10;
            colorGroupBox.TabStop = false;
            colorGroupBox.Text = "Color Scheme";
            // 
            // secondColorBox
            // 
            secondColorBox.BackColor = SystemColors.Window;
            secondColorBox.Location = new Point(113, 46);
            secondColorBox.Name = "secondColorBox";
            secondColorBox.Size = new Size(99, 74);
            secondColorBox.TabIndex = 16;
            secondColorBox.TabStop = false;
            secondColorBox.Click += colorBox_Click;
            // 
            // primaryColorBox
            // 
            primaryColorBox.BackColor = SystemColors.Window;
            primaryColorBox.Location = new Point(6, 46);
            primaryColorBox.Name = "primaryColorBox";
            primaryColorBox.Size = new Size(99, 74);
            primaryColorBox.TabIndex = 11;
            primaryColorBox.TabStop = false;
            primaryColorBox.Click += colorBox_Click;
            // 
            // secondColorLabel
            // 
            secondColorLabel.AutoSize = true;
            secondColorLabel.Location = new Point(113, 23);
            secondColorLabel.Name = "secondColorLabel";
            secondColorLabel.Size = new Size(98, 20);
            secondColorLabel.TabIndex = 15;
            secondColorLabel.Text = "Second Color";
            // 
            // primaryColorLabel
            // 
            primaryColorLabel.AutoSize = true;
            primaryColorLabel.Location = new Point(6, 23);
            primaryColorLabel.Name = "primaryColorLabel";
            primaryColorLabel.Size = new Size(99, 20);
            primaryColorLabel.TabIndex = 14;
            primaryColorLabel.Text = "Primary Color";
            // 
            // HeroMaker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 545);
            Controls.Add(colorGroupBox);
            Controls.Add(createButton);
            Controls.Add(statisticsGroupBox);
            Controls.Add(otherGroupBox);
            Controls.Add(vehicleGroupBox);
            Controls.Add(locationsGroupBox);
            Controls.Add(datesGroupBox);
            Controls.Add(powersGroupBox);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Name = "HeroMaker";
            Text = "Hero Maker";
            powersGroupBox.ResumeLayout(false);
            powersGroupBox.PerformLayout();
            datesGroupBox.ResumeLayout(false);
            datesGroupBox.PerformLayout();
            locationsGroupBox.ResumeLayout(false);
            vehicleGroupBox.ResumeLayout(false);
            vehicleGroupBox.PerformLayout();
            otherGroupBox.ResumeLayout(false);
            otherGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)braverySlider).EndInit();
            ((System.ComponentModel.ISupportInitialize)experienceNumUpDown).EndInit();
            statisticsGroupBox.ResumeLayout(false);
            statisticsGroupBox.PerformLayout();
            colorGroupBox.ResumeLayout(false);
            colorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)secondColorBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)primaryColorBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameTextBox;
        private GroupBox powersGroupBox;
        private CheckBox speedCheckBox;
        private CheckBox laserVisionCheckBox;
        private CheckBox telepathyCheckBox;
        private CheckBox invisibilityCheckBox;
        private CheckBox flightCheckBox;
        private CheckBox strengthCheckBox;
        private GroupBox datesGroupBox;
        private DateTimePicker discoveryDatePicker;
        private Label discoveryLabel;
        private Label birthdayLabel;
        private DateTimePicker birthdayDatePicker;
        private GroupBox locationsGroupBox;
        private ListBox locationsListBox;
        private GroupBox vehicleGroupBox;
        private RadioButton boatRadioButton;
        private RadioButton bikeRadioButton;
        private RadioButton carRadioButton;
        private RadioButton jetRadioButton;
        private GroupBox otherGroupBox;
        private Label braveryTrackBar;
        private TrackBar braverySlider;
        private NumericUpDown experienceNumUpDown;
        private Label experienceLabel;
        private HScrollBar durabilityHScroll;
        private Label durabilityLabel;
        private GroupBox statisticsGroupBox;
        private HScrollBar intelligenceHScroll;
        private Label intelligenceLabel;
        private Button createButton;
        private Label leadershipValueLabel;
        private Label intelligenceValueLabel;
        private Label durabilityValueLabel;
        private HScrollBar leadershipHScroll;
        private Label leadershipLabel;
        private GroupBox colorGroupBox;
        private PictureBox secondColorBox;
        private PictureBox primaryColorBox;
        private Label secondColorLabel;
        private Label primaryColorLabel;
        private ColorDialog colorDialog;
        private Label braveryValueLabel;
    }
}