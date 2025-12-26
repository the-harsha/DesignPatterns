using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.Design_Patterns.Creational.Builder.GoodExample.Components
{
    public class Wheels
    {
        private float _diameterInInches;
        public Wheels(float diameterInInches)
        {
            _diameterInInches = diameterInInches;
        }
        public float GetDiameterInInches()
        {
            return _diameterInInches;
        }
    }
}
