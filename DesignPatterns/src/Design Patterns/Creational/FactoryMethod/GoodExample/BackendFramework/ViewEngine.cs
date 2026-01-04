using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.src.DesignPatterns.Creational.FactoryMethod.GoodExample.BackendFramework
{
    public interface ViewEngine
    {
        string Render(string fileName, Dictionary<string, object> data);
    }
}