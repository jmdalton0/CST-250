namespace AnimalsConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Animal animal = new Animal();

            animal.Talk();
            animal.Greet();
            animal.Sing();
            */

            Dog dog = new Dog();

            dog.Talk();
            dog.Greet();
            dog.Sing();
            dog.Fetch("stick");
            dog.FeedMe();
            dog.TouchMe();

            Robin robin = new Robin();

            robin.Talk();
            robin.Greet();
            robin.Sing();

            Cow cow = new Cow();

            cow.Talk();
            cow.Slaughter();
            cow.Butcher();
            cow.Cook();
            cow.Milk();
            cow.TouchMe();
            cow.Greet();

            Pig pig = new Pig();

            pig.Talk();
            pig.Sing();
            pig.Butcher();
            pig.Cook();

            Cougar cougar = new Cougar();

            cougar.Talk();
            cougar.Sing();
            cougar.Milk();

            Console.ReadLine();
        }
    }
}