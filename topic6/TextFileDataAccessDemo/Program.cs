namespace TextFileDataAccessDemo
{
    class Program
    {
        static void Main(String[] args)
        {
            string inFile = @"C:\Users\jmdal\Projects\CST250\topic6\in.txt";
            List<Person> people = new List<Person>();
            List<string> lines = File.ReadAllLines(inFile).ToList();

            foreach (string line in lines)
            {
                string[] entries = line.Split(',');

                try
                {
                    Person person = new Person();
                    person.firstName = entries[0];
                    person.lastName = entries[1];
                    person.instrument = entries[2];

                    people.Add(person);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Malformed File Data");
                }
            }

            Person p = new Person();
            p.firstName = "John";
            p.lastName = "Bonham";
            p.instrument = "drums";
            people.Add(p);

            List<string> outLines = new List<string>();
            Console.WriteLine("People:");
            foreach (Person person in people)
            {
                Console.WriteLine("First Name: " + person.firstName + " Last Name: " + person.lastName + " Instrument: " + person.instrument);
                outLines.Add("First Name: " + person.firstName + " Last Name: " + person.lastName + " Instrument: " + person.instrument);
            }

            string outFile = @"C:\Users\jmdal\Projects\CST250\topic6\out.txt";
            File.WriteAllLines(outFile, outLines);
        }

        /*
        static void Main(String[] args)
        {
            string inFile = @"C:\Users\jmdal\Projects\CST250\topic6\in.txt";
            List<String> lines = File.ReadAllLines(inFile).ToList();

            lines.Add("Robert Plant");

            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }

            File.WriteAllLines(inFile, lines);
        }
        */
    }
}
