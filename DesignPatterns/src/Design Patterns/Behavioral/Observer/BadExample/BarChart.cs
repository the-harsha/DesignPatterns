using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.Design_Patterns.Behavioral.Observer.BadExample
{
    public class BarChart
    {
        public void Render(List<int> values)
        {
            System.Console.WriteLine("Rendering bar chart with new values");
        }
    }
}
