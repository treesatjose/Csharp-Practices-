
internal class ArmstrongNumber
{
    protected static void Main(string[] args)
    {
        
            int n, r, sum = 0, temp;
            Console.WriteLine("Enter a number");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + r * r * r;
                n = n / 10;
            }
            if (temp == sum)
                Console.WriteLine("Armstrong number");
            else
                Console.WriteLine("not Armstrong");
       
    }
}