using DesignPatterns.src.Design_Patterns.Creational.AbstractFactory.BadExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.Design_Patterns.Creational.AbstractFactory.GoodExample.Mac
{
    public class MacButton : IButton
    {
        public void Render()
        {
            System.Console.WriteLine("Mac: render button");
        }
    }
}
