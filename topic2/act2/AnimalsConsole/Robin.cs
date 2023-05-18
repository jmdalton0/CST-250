using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsConsole
{
    internal class Robin : Animal
    {
        public virtual void Sing()
        {
            Console.WriteLine("Chirp Chirp");
        }
    }
}
