
//Call the GetInstance static method to get the Singleton Instance
Singleton fromTeachaer = Singleton.Instance;
fromTeachaer.PrintDetails("From Teacher");
//Call the GetInstance static method to get the Singleton Instance
Singleton fromStudent = Singleton.Instance;
fromStudent.PrintDetails("From Student");
Singleton fromStudent1 = Singleton.Instance;
fromStudent1.PrintDetails("From Student1");
Console.ReadLine();

public sealed class Singleton
{
    private static int Counter = 0;
    private Singleton() {
        Counter++;
        Console.WriteLine("Counter Value " + Counter.ToString());
    }
    private static Singleton instance = null;
    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
    public void PrintDetails(string message)
    {
        Console.WriteLine(message);
    }

}