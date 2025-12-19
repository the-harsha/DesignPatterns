using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.SOLID.D.BetterExample
{
    public class Car
    {
        private IEngine engine;
        public Car(IEngine engine)
        {
            this.engine = engine;
        }
        public void StartCar()
        {
            engine.Start();
            System.Console.WriteLine("Car started.");
        }
    }
}
