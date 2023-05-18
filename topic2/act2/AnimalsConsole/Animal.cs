﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsConsole
{
    abstract class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal Constructor");
        }

        public void Greet()
        {
            Console.WriteLine("Animal says hello");
        }

        public void Talk()
        {
            Console.WriteLine("Animal is talking");
        }

        public virtual void Sing()
        {
            Console.WriteLine("Animal is singing");
        }

    }
}
