using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class ConcreteStateB : IState
    {
        public void StateSpecificBehavior(Context context)
        {
            Console.WriteLine("State is B, switching to A");
            context.setState(new ConcreteStateA());
        }
    }
}
