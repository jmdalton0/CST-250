using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Trim { get; set; }
        public decimal MPG { get; set; }
        public decimal Price{ get; set; }

        public Car(string make, string model, string trim, decimal mpg, decimal price)
        {
            Make = make;
            Model = model;
            Trim = trim;
            MPG = mpg;
            Price = price;
        }

        public Car()
        {
            Make = "?";
            Model = "?";
            Trim = "?";
            MPG = 0;
            Price = 0;
        }

        public override string ToString()
        {
            return Make + " " + Model + " " + Trim + " $" + Price + " mpg:" + MPG;
        }
    }
}
