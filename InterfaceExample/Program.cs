
interface IFile
{
    void ReadFile();
    void WriteFile(string text);
}

class FileInfo : IFile
{
    public void ReadFile()
    {
        Console.WriteLine("reading file");
    }
    public void WriteFile(string text)
    {
        Console.WriteLine("writing file");
    }
}
public class Program
{
    private static void Main(string[] args)
    {
        IFile f1 = new FileInfo();
        FileInfo f2 = new FileInfo();

        f1.ReadFile();
        f1.WriteFile("interface");

        f2.ReadFile();
        f2.WriteFile("content");


    }
}