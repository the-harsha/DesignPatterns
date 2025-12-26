using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.src.DesignPatterns.Behavioral.ChainOfResponsibility.GoodExample
{
    public class Logger : Handler
    {
        public override bool DoHandle(HttpRequest request)
        {
            System.Console.WriteLine("Logging");
            return false;
        }
    }
}