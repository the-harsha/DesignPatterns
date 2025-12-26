using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.Design_Patterns.Creational.AbstractFactory.BadExample.Windows
{
    public class WindowsCheckbox : ICheckbox
    {
        public void Render()
        {
            System.Console.WriteLine("Windows: render checkbox");
        }
    }
}
