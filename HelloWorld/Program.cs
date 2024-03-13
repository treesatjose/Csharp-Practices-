//Console.WriteLine("Hello, good morning!");

internal class Program
{
     static void Main(string[] args)
    {
        string str = "This is a new string";
        foreach (char c in str)
        {
            //Console.Write(c);
            if (c == 'a')
            {
                // Console.WriteLine();
                break;
            }
        }
        string st1 = "hello";
        string st2 = "hii GELL";
        bool isEqual = st2.Equals(st1);
        //Console.WriteLine(isEqual);

        //Console.WriteLine(st1.IndexOf('o'));
        string str3 = st2.Replace("GELL", "snow");
        //Console.WriteLine(str3);

        int i = 123;
        decimal d = 544.18m;
        Console.WriteLine("{0:D},{0:N},{0:F},{0:G}", i);
        Console.WriteLine("{0:E}, {0:N},{0:F},{0:G}", d);

        //to add a number format with precision
        // Console.WriteLine("{0:D6},{0:N3},{0:F1},{0:G9}", i);

        // Console.WriteLine("{0,12} {1,12} {2,12} {3,12}", quarters[0]);

    }
}