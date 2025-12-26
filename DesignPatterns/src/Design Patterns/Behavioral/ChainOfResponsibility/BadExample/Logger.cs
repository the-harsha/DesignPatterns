using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.src.DesignPatterns.Behavioral.ChainOfResponsibility.BadExample
{
    public class Logger
    {
        public void Log(HttpRequest request)
        {
            System.Console.WriteLine("Log");
        }
    }
}