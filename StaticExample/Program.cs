
public class StopWatch
{
    //static constructor
    //call only once when the program runs
    static StopWatch()
    {
        Console.WriteLine("static constructor called");
    }
    //instance constructor
    public StopWatch()
    {
        Console.WriteLine("instance constructor called");
    }
    //static method
    public static void DisplayInfo()
    {
        Console.WriteLine("DisplayInfo static method called");
    }
}
public class Program
{
    private static void Main(string[] args)
    {
        StopWatch.DisplayInfo();
        StopWatch.DisplayInfo();

    }
}