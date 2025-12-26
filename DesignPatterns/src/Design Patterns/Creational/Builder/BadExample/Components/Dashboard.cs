using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.Design_Patterns.Creational.Builder.BadExample.Components
{
    public class Dashboard
    {
        private bool _hasRevCounter = false;
        public Dashboard(bool hasRevCounter)
        {
            _hasRevCounter = hasRevCounter;
        }
    }
}
