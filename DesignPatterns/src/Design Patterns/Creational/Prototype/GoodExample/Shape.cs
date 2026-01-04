using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.Design_Patterns.Creational.Prototype.GoodExample
{
    public interface Shape
    {
        void Draw();
        Shape Duplicate();
    }
}
