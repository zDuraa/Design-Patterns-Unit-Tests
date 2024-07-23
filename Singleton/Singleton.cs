public class Singleton
{ 
    public static Singleton GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Singleton();
        }
        return _instance;
    }

    protected Singleton()
    {
        Console.WriteLine("Construktor Singleton");
    }


    private static Singleton? _instance = null;

    private string _name = "";
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

}
