using DesignPatterns.src.Design_Patterns.Behavioral.Command.RemoteControl.BadExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DesignPatterns.src.Design_Patterns.Behavioral.Command.RemoteControl.GoodExample
{
    public class DimCommand : ICommand
    {
        private Light _light;

        public DimCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.Dim();
        }
    }
}
