using DesignPatterns.src.Design_Patterns.Creational.AbstractFactory.BadExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.Design_Patterns.Creational.AbstractFactory.GoodExample.Windows
{
    public class WindowsUIComponentFactory : IUIComponentFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }
        public ICheckbox CreateCheckbox()
        {
            return new WindowsCheckbox();
        }
    }
}
