using DesignPatterns.src.Design_Patterns.Structural.Adapter.ThirdPartyColorLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.Design_Patterns.Structural.Adapter
{
    // Adapter class. Rainbow is the adaptee
    public class RainbowColor : Color
    {
        private Rainbow _rainbow; // "composition" -- RainbowColor is composed of, "has a", Rainbow. See RainbowAdapter for inheritance alternative.
        public RainbowColor(Rainbow rainbow)
        {
            _rainbow = rainbow;
        }
        public void Apply(Video video)
        {
            _rainbow.Setup();
            _rainbow.Update(video);
        }
    }
}
