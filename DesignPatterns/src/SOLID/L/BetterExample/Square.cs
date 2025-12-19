using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.SOLID.L.BetterExample
{
    public class Square : Shape
    {
        private double sideLength;
        public double SideLength
        {
            get => sideLength;
            set
            {
                sideLength = value;
            }
        }
        public override double Area => sideLength * sideLength;
    }
}
