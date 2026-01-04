using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.Design_Patterns.Structural.Adapter
{
    public class BlackAndWhiteColor : Color
    {
        public void Apply(Video video)
        {
            System.Console.WriteLine("Applying black and white color to video");
        }
    }
}
