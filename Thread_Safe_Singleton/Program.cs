Singleton obja = Singleton.Instance;
obja.PrintDetails("From obja");
Singleton objb = Singleton.Instance;
objb.PrintDetails("From objb");
public sealed class Singleton
{
    public static int Counter = 0;
    private Singleton()
    {
        Counter++;
        Console.WriteLine("Counter Value " + Counter.ToString());
    }
    private static readonly object lockName=new object();
    private static Singleton instance = null;
    public static Singleton Instance
    {
        get
        {
            lock (lockName)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
            }
            return instance;
        }
    }
    public void PrintDetails(string message)
    {
        Console.WriteLine(message);
    }
}