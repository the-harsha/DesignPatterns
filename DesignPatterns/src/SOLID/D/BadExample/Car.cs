using DesignPatterns.src.OopPrinciples.Composition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.SOLID.D.BadExample
{
    public class Car
    {
        private Engine engine;
        public Car()
        {
            this.engine = new Engine(); // Direct dependency on Engine class
        }
        public void StartCar()
        {
            engine.Start();
            System.Console.WriteLine("Car started.");
        }
    }
}
