using TextFileDataAccessDemo;

namespace TextFileDataAccessGUI
{
    public partial class Form1 : Form
    {
        private const string PATH = @"C:\Users\jmdal\Projects\CST250\topic6\save.txt";

        private List<Person> people;

        public Form1()
        {
            InitializeComponent();
            people = new List<Person>();
        }

        private void updateList()
        {
            listBox1.Items.Clear();
            foreach (Person person in people)
            {
                listBox1.Items.Add(person.toString());
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.firstName = firstNameTextBox.Text;
            person.lastName = lastNameTextBox.Text;
            person.instrument = instrumentTextBox.Text;

            people.Add(person);
            updateList();

            firstNameTextBox.Text = String.Empty;
            lastNameTextBox.Text = String.Empty;
            instrumentTextBox.Text = String.Empty;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>();
            try
            {
                lines = File.ReadAllLines(PATH).ToList();
            }
            catch (Exception ex)
            {
                File.Create(PATH).Close();
            }

            people.Clear();
            foreach (string line in lines)
            {
                string[] entries = line.Split('|');

                try
                {
                    Person person = new Person();
                    person.firstName = entries[0];
                    person.lastName = entries[1];
                    person.instrument = entries[2];
                    people.Add(person);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Malformed File Data");
                }
            }
            updateList();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>();
            foreach (Person person in people)
            {
                lines.Add(person.firstName + "|" + person.lastName + "|" + person.instrument);
            }
            File.WriteAllLines(PATH, lines);
        }
    }
}