using DesignPatterns.src.Design_Patterns.Behavioral.Strategy.BadExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.Design_Patterns.Behavioral.Strategy.GoodExample
{
    public class CompressorMP4 : ICompressor
    {
        public void Compress()
        {
            System.Console.WriteLine("Compressing video using MP4");
        }
    }
}
