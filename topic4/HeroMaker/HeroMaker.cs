using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroMaker
{
    public partial class HeroMaker : Form
    {
        private Hero hero;
        private int oldDurability;
        private int oldIntelligence;
        private int oldLeadership;

        public HeroMaker(Hero hero)
        {
            InitializeComponent();
            this.hero = hero;
            this.oldDurability = 0;
            this.oldIntelligence = 0;
            this.oldLeadership = 0;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Name cannot be empty.");
            }
            else
            {
                hero.setName(nameTextBox.Text);
                hero.setBirthDate(birthdayDatePicker.Value.Date);
                hero.setDiscoverDate(discoveryDatePicker.Value.Date);
                capturePowers();
                captureLocations();
                captureVehicle();
                hero.setExperience((int)experienceNumUpDown.Value);
                hero.setBravery(braverySlider.Value);
                hero.setDurability(durabilityHScroll.Value);
                hero.setIntelligence(intelligenceHScroll.Value);
                hero.setLeadership(leadershipHScroll.Value);
                hero.setPrimaryColor(primaryColorBox.BackColor);
                hero.setSecondColor(secondColorBox.BackColor);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void braverySlider_Slide(object sender, EventArgs e)
        {

            braveryValueLabel.Text = braverySlider.Value.ToString();
        }

        private void statisticHScroll_Scroll(object sender, ScrollEventArgs e)
        {
            durabilityValueLabel.Text = durabilityHScroll.Value.ToString();
            intelligenceValueLabel.Text = intelligenceHScroll.Value.ToString();
            leadershipValueLabel.Text = leadershipHScroll.Value.ToString();
            if (e.Type == ScrollEventType.EndScroll)
            {
                if (durabilityHScroll.Value + intelligenceHScroll.Value + leadershipHScroll.Value > 100)
                {
                    HScrollBar hScrollBar = (HScrollBar)sender;
                    if (hScrollBar.Name == "durabilityHScroll")
                    {
                        e.NewValue = oldDurability;
                        durabilityValueLabel.Text = oldDurability.ToString();
                    }
                    if (hScrollBar.Name == "intelligenceHScroll")
                    {
                        e.NewValue = oldIntelligence;
                        intelligenceValueLabel.Text = oldIntelligence.ToString();
                    }
                    if (hScrollBar.Name == "leadershipHScroll")
                    {
                        e.NewValue = oldLeadership;
                        leadershipValueLabel.Text = oldLeadership.ToString();
                    }
                    MessageBox.Show("Statistics Total must not exceed 100");
                }
                else
                {
                    oldDurability = durabilityHScroll.Value;
                    oldIntelligence = intelligenceHScroll.Value;
                    oldLeadership = leadershipHScroll.Value;
                }
            }
        }

        private void colorBox_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                PictureBox colorBox = (PictureBox)sender;
                if (colorBox.Name == "primaryColorBox")
                {
                    primaryColorBox.BackColor = colorDialog.Color;
                }
                else
                {
                    secondColorBox.BackColor = colorDialog.Color;
                }
            }
        }

        private void capturePowers()
        {
            foreach (CheckBox power in powersGroupBox.Controls.OfType<CheckBox>())
            {
                if (power.Checked)
                {
                    this.hero.addPower(power.Text);
                }
            }
        }

        private void captureLocations()
        {
            for (int i = 0; i < locationsListBox.Items.Count; i++)
            {
                if (locationsListBox.GetSelected(i))
                {
                    this.hero.addLocation(locationsListBox.Items[i].ToString());
                }
            }
        }

        private void captureVehicle()
        {
            this.hero.setVehicle(vehicleGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text);
        }
    }
}
