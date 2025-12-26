using DesignPatterns.src.Design_Patterns.Creational.AbstractFactory.BadExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.Design_Patterns.Creational.AbstractFactory.GoodExample.Mac
{
    public class MacUIComponentFactory : IUIComponentFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }
        public ICheckbox CreateCheckbox()
        {
            return new MacCheckbox();
        }
    }
}
