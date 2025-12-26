using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.Design_Patterns.Behavioral.State.GoodExample
{
    public interface State
    {
        void Publish();

        // A real Document would have more state-dependent methods, such as Render() -- but we'll keep it simple with one method for this example.
    }
}
