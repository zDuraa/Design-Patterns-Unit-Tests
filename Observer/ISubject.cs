using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


interface ISubject
{
    void vAttach(IObserver observer);

    void vDetach(IObserver observer);

    void vNotify();

}

