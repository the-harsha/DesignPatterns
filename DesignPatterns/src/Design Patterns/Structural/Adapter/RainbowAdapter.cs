using DesignPatterns.src.Design_Patterns.Structural.Adapter.ThirdPartyColorLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.Design_Patterns.Structural.Adapter
{
    public class RainbowAdapter : Rainbow, Color
    {
        public void Apply(Video video)
        {
            Setup();
            Update(video);
        }
    }
}
