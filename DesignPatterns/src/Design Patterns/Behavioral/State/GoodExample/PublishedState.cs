using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.Design_Patterns.Behavioral.State.GoodExample
{
    public class PublishedState : State
    {
        private Document _document;

        public PublishedState(Document document)
        {
            _document = document;
        }
        public void Publish()
        {
            // do nothing
        }
    }
}
