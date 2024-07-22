using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Subject : ISubject
{
    Subject(string strname) 
    {
        strname_subject_ = strname;
    }
    public void vAttach(IObserver observer)
    {
        list_observer.Prepend(observer);
    }
    public void vDetach(IObserver observer)
    {
        list_observer.Remove(observer);
    }
    public void vNotify()
    {
        foreach (var ait in list_observer)
        {
            ait.vUpdate(message_);
        }
    }
    public void vCreateMessage(string message)
    {
        message_ = message;
        vNotify();
    }
    public void vSomeBusinessLogic()
    {
        message_ = "change message message";
        vNotify();
        Console.WriteLine("I'm about to do something important");
    }

    private List<IObserver> list_observer = new List<IObserver>();
    private string message_;
    private string strname_subject_;

}

