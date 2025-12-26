using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.Design_Patterns.Behavioral.Command.RemoteControl.GoodExample
{
    // "Invoker": the remote control
    public class RemoteControl
    {
        private ICommand _command;

        public RemoteControl(ICommand command)
        {
            _command = command;
        }
        // Allow ability to swap commands at runtime
        public void SetCommand(ICommand command)
        {
            _command = command;
        }
        public void PressButton()
        {
            _command.Execute();
        }
    }
}
