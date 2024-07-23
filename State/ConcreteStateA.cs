using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class ConcreteStateA : IState
    {
        public void StateSpecificBehavior(Context context)
        {
            Console.WriteLine("State is A, switching to B");
            context.setState(new ConcreteStateB());
        }
    }
}
