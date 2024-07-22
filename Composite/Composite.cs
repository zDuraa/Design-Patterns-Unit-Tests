using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Composite : Component
{
    public void vExecute()
    {
        Console.WriteLine("vExecute Composite");
        foreach(var ait in listComponents_)
        {
            ait.vExecute();
        }
    }
    public void vAdd(Component component)
    {
        listComponents_.Prepend(component);
    }
    public void vRemove(Component component)
    {
        listComponents_.Remove(component);
    }

    private List<Component> listComponents_ = new List<Component>();
}

