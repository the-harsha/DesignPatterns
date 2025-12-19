using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.OopPrinciples.Polymorphism.BadExample
{
    public class Motorcycle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void Start()
        {
            Console.WriteLine("Motorcycle is starting.");
        }

        public void Stop()
        {
            Console.WriteLine("Motorcycle is stopping.");
        }
    }
}
