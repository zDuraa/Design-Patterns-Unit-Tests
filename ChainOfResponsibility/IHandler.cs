using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public interface IHandler
    {
        public void SetNextHandler(IHandler nextHandler);
        public void HandleRequest(string request);
    }
}
