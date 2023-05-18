using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class CountToOne
    {
        static public int countToOne(int n)
        {
            Console.WriteLine("n is {0}", n);
            if (n == 1)
            {
                return 1;
            }
            else
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine("n is even - divide by 2");
                    return countToOne(n / 2);
                }
                else
                {
                    Console.WriteLine("n is odd - add 1");
                    return countToOne(n + 1);
                }
            }
        }
    }
}
