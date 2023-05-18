using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsConsole
{
    internal class Dog : Animal, IDomesticated
    {
        public Dog()
        {
            Console.WriteLine("Dog constructor");
        }

        public new void Talk()
        {
            Console.WriteLine("Bark Bark Bark");
        }

        public override void Sing()
        {
            Console.WriteLine("Howl");
        }

        public void Fetch(String thing)
        {
            Console.WriteLine("Here is the " + thing);
        }

        public void TouchMe()
        {
            Console.WriteLine("Scratch me");
        }

        public void FeedMe()
        {
            Console.WriteLine("Its suppertime");
        }
    }
}
