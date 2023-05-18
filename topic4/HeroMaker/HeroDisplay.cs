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
    public partial class HeroDisplay : Form
    {
        private HeroList heroes;

        public HeroDisplay()
        {
            InitializeComponent();
            heroes = new HeroList();
        }

        private void addHeroButton_Click(object sender, EventArgs e)
        {
            Hero hero = new Hero();
            HeroMaker heroMaker = new HeroMaker(hero);
            if (heroMaker.ShowDialog() == DialogResult.OK)
            {
                heroes.add(hero);
            }
            updateList();
        }

        private void updateList()
        {
            heroListBox.Items.Clear();
            foreach (Hero hero in heroes.all())
            {
                heroListBox.Items.Add(hero.getName());
            }
        }

        private void heroListBox_Select(object sender, EventArgs e)
        {
            String name = (String)heroListBox.SelectedItem;
            Hero hero = heroes.getByName(name);
            descriptionTextBox.Text = hero.ToString();
        }
    }
}
