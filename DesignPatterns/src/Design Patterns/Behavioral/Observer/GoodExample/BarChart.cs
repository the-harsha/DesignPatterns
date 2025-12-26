using DesignPatterns.src.Design_Patterns.Behavioral.Observer.BadExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.Design_Patterns.Behavioral.Observer.GoodExample
{
    public class BarChart : Observer
    {
        private DataSource _dataSource;

        public BarChart(DataSource dataSource)
        {
            _dataSource = dataSource;
        }
        public void Update()
        {
            System.Console.WriteLine("Rendering bar chart with new values");
        }
    }
}
