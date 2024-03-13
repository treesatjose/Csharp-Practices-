class Test
{
    static void Main(string[] args)
    {
        string s1 = "tear reet";
        string s2 = "tear reet";

        using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
        {
            //  while (!reader.EndOfStream)
            //{
            string inputLine = s1;

            if (IsAnagram(inputLine, s2))
            {
                Console.WriteLine("it is anagram");
            }
            else
            {
                Console.WriteLine("not anagram");
            }
            // }

        }
    }
    static bool IsAnagram(string s1, string s2)
    {
        if (s1.Length != s2.Length)
        {
            return false;
        }
        char[] ch1 = s1.ToLower().ToCharArray();
        char[] ch2 = s2.ToLower().ToCharArray();
        Array.Sort(ch1);
        Array.Sort(ch2);

        for (int i = 0; i < ch1.Length; i++)
        {
            if (ch1[i] != ch2[i])
            {
                return false;
            }
        }
        return true;

    }
}