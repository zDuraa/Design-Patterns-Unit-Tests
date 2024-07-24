using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class ConcreteHandler1 : AbstractHandler
    {
        public override void HandleRequest(string request)
        {
            if (request == "Request1")
            {
                Console.WriteLine("ConcreteHandler1 handled the request.");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
        }
    }
}
