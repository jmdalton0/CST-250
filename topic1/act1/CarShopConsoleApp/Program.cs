using CarClassLibrary;
using System.ComponentModel.Design;

namespace CarShopConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Car Store.");

            Store store = new Store();
            int action = 1;
            while (action != 0)
            {
                Console.WriteLine("Choose an action: | 0 Quit | 1 Add Car | 2 Add to Cart | 3 Checkout");
                action = int.Parse(Console.ReadLine());

                switch (action)
                {
                    case 0: Console.WriteLine("Goodbye");
                        break;
                    case 1: AddCar(store);
                        break;
                    case 2: AddToCart(store);
                        break;
                    case 3: Checkout(store);
                        break;
                    default: Console.WriteLine("invalid");
                        break;
                }
            }
        }

        static public void printStoreInventory(Store store)
        {
            Console.WriteLine("Inventory:");
            for (int i = 0; i < store.CarList.Count; i++)
            {
                Console.WriteLine(i + ") " + store.CarList.ElementAt(i).ToString());
            }
        }

        static public void printShoppingList(Store store)
        {
            Console.WriteLine("Shopping List:");
            for (int i = 0; i < store.ShoppingList.Count; i++)
            {
                Console.WriteLine(i + ") " + store.ShoppingList.ElementAt(i).ToString());
            }
        }

        static void AddCar(Store store)
        {
            Console.WriteLine("Add a new Car to the store:");
            Console.WriteLine("What is the car make?");
            string make = Console.ReadLine();
            Console.WriteLine("What is the car model?");
            string model = Console.ReadLine();
            Console.WriteLine("What is the car trim?");
            string trim = Console.ReadLine();
            Console.WriteLine("What is the car mpg?");
            decimal mpg = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the car price?");
            decimal price = int.Parse(Console.ReadLine());

            Car newCar = new Car();
            newCar.Make = make;
            newCar.Model = model;
            newCar.Trim = trim;
            newCar.MPG = mpg;
            newCar.Price = price;
            store.CarList.Add(newCar);
            printStoreInventory(store);
        }

        static void AddToCart(Store store)
        {
            printStoreInventory(store);
            int choice = 0;
            Console.WriteLine("Which car would you like to add?");
            choice = int.Parse(Console.ReadLine());
            store.ShoppingList.Add(store.CarList[choice]);
            printShoppingList(store);
        }

        static void Checkout(Store store)
        {
            printShoppingList(store);
            Console.WriteLine("Your total is " + store.checkout());
        }
    }
}

