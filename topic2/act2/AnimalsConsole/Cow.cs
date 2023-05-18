using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsConsole
{
    internal class Cow : Animal, IEdible, IMilkable, IDomesticated
    {
        public void Butcher()
        {
            Console.WriteLine("Cow is butchered");
        }

        public void Cook()
        {
            Console.WriteLine("Cow is cooked");
        }

        public void FeedMe()
        {
            Console.WriteLine("Its suppertime");
        }

        public void Milk()
        {
            Console.WriteLine("Cow is milked");
        }

        public void Slaughter()
        {
            Console.WriteLine("Cow is slaughtered");
        }

        public void Talk()
        {
            Console.WriteLine("Mooo");
        }

        public void TouchMe()
        {
            Console.WriteLine("Scratch my back");
        }
    }
}
