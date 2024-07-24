using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public abstract class AbstractHandler : IHandler
    {
        protected IHandler? _nextHandler;

        public void SetNextHandler(IHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public abstract void HandleRequest(string request);
    }
}
