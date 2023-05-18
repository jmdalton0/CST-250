namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recursion\n\n");

            // Count to One
            /*
            Console.WriteLine("Operation 1: Count to One");
            Console.Write("Enter an integer: ");
            int n = int.Parse(Console.ReadLine());
            int result = CountToOne.countToOne(n);
            Console.WriteLine("\n");

            // Factorial
            Console.WriteLine("Operation 2: Factorial");
            Console.Write("Enter an integer: ");
            n = int.Parse(Console.ReadLine());
            result = Factorial.factorial(n);
            Console.WriteLine("{0}! = {1}", n, result);
            Console.WriteLine("\n");

            // GCD
            Console.WriteLine("Operation 3: Greatest Common Denominator");
            Console.Write("Enter an integer: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Enter an integer: ");
            int m = int.Parse(Console.ReadLine());
            result = GCD.gcd(n, m);
            Console.WriteLine("The GCD of {0} and {1} is {2}", n, m, result);
            Console.WriteLine("\n");
            */

            // Knight's Tour
            while (true)
            {
                Console.WriteLine("Operation 4: Knight's Tour");
                Console.Write("Enter a board size: ");
                int size = int.Parse(Console.ReadLine());
                Console.Write("Enter a starting row: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Enter a starting column: ");
                int y = int.Parse(Console.ReadLine());
                KnightTour kt = new KnightTour();
                kt.solve(size, x, y);
            }
        }
    }
}