using DesignPatterns.src.Design_Patterns.Behavioral.State.BadExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.Design_Patterns.Behavioral.State.GoodExample
{
    public class ModerationState : State
    {
        private Document _document;

        public ModerationState(Document document)
        {
            _document = document;
        }
        public void Publish()
        {
            if (_document.CurrentUserRole == UserRoles.ADMIN)
            {
                _document.State = new PublishedState(_document);
            }
        }
    }
}
