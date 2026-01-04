using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.Design_Patterns.Creational.FactoryMethod.BadExample.BackEndFramework
{
    public class Controller
    {
        public void Render(string fileName, Dictionary<string, object> data, ViewEngine viewEngine)
        {
            var html = viewEngine.Render(fileName, data);
            System.Console.WriteLine(html);
        }
    }
}
