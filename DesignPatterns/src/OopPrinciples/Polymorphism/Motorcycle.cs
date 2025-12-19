using DesignPatterns.src.OopPrinciples.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.OopPrinciples.Polymorphism
{
    public class Motorcycle : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Motorcycle is starting.");
        }

        public override void Stop()
        {
            Console.WriteLine("Motorcycle is stopping.");
        }
    }
}
