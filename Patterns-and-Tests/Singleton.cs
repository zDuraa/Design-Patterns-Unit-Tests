class Singleton
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

    private static Singleton _instance = null;

}
