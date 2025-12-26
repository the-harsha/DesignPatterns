using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.Design_Patterns.Creational.AbstractFactory.BadExample.App
{
    public class UserSettingsForm
    {
        public void Render(OperatingSystemType os)
        {
            // PROBLEM: open-closed principle violated: if add new OS, we have to modify this class
            if (os == OperatingSystemType.Windows)
            {
                // PROBLEM: too easy to make mistake -- e.g. easy to accidentally render a Mac button here.
                new WindowsButton().Render();
                // PROBLEM: UserSettingsForm is tightly coupled to many concrete implementations of widgets.
                new WindowsCheckbox().Render();
            }
            else if (os == OperatingSystemType.Mac)
            {
                new MacButton().Render();
                new MacCheckbox().Render();
            }
        }
    }
}
