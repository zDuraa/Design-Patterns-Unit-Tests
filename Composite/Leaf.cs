using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Leaf : Component
{
    public void vExecute()
    {
        Console.WriteLine(" vExecute Leaf");
    }
    public void vAdd(Component component)
    {
        throw new InvalidOperationException("Cannot add to a leaf");
    }

    public void vRemove(Component component)
    {
        throw new InvalidOperationException("Cannot remove from a leaf");
    }
}

