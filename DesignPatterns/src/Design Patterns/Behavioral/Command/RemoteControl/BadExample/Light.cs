using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.Design_Patterns.Behavioral.Command.RemoteControl.BadExample
{
    // "Receiver": the light
    public class Light
    {
        public void TurnOn()
        {
            System.Console.WriteLine("Light is on");
        }
        public void TurnOff()
        {
            System.Console.WriteLine("Light is off");
        }
        public void Dim()
        {
            System.Console.WriteLine("Light is dim");
        }
    }
}
