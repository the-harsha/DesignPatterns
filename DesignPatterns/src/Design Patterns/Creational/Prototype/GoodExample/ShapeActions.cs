using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.Design_Patterns.Creational.Prototype.GoodExample
{
    public class ShapeActions
    {
        public Shape Duplicate(Shape shape)
        {
            System.Console.WriteLine("Duplicating shape");
            return shape.Duplicate();
        }
    }
}
