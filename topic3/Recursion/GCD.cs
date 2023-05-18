using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class GCD
    {
        static public int gcd(int x, int y)
        {
            if (y == 0)
            {
                return x;
            }
            else
            {
                Console.WriteLine("Remainder is {0}", x % y);
                return gcd(y, x % y);
            }
        }
    }
}
