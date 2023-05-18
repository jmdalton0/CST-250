using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsConsole
{
    internal class Pig : Animal, IEdible
    {
        public override void Sing()
        {
            Console.WriteLine("Squeal");
        }

        public void Butcher()
        {
            Console.WriteLine("Pig is butchered");
        }

        public void Cook()
        {
            Console.WriteLine("Pig is cooked");
        }

        public void Slaughter()
        {
            Console.WriteLine("Pig is slaughtered");
        }
    }
}
