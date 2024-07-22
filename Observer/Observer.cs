using System.ComponentModel;

class Observer : IObserver
{
    Observer(Subject subject, string strname)
    {
        subject_ = subject;
        strname_observer_ = strname;
    }

    public void vUpdate(string message)
    {
        message_from_subject = message;
        Console.WriteLine(strname_observer_ +  " received message: " + message_from_subject);
    }

    private string message_from_subject;
    private Subject subject_;
    private string strname_observer_;
}
