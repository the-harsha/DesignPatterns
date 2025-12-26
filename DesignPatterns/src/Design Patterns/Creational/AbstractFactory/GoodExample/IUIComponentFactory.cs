using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.Design_Patterns.Creational.AbstractFactory.GoodExample
{
    public interface IUIComponentFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}
