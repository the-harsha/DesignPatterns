using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.SOLID.D.BetterExample
{
    public class Engine : IEngine // our "low-level" module
    {
        public void Start()
        {
            System.Console.WriteLine("Engine started.");
        }
    }
}
