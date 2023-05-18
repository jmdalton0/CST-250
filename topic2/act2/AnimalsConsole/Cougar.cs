using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsConsole
{
    internal class Cougar : Animal, IMilkable
    {
        public void Milk()
        {
            Console.WriteLine("I am not domesticated but try to milk me");
        }
    }
}
