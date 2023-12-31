namespace FirstProject;

public class WordFile : IFile
{
    public string FileName { get; set; }
    public int Size { get; set; }
    public DateTime CreatedOn { get; set; }

    public  void Compress()
    {
        Console.WriteLine("Compressing Word");
    }
    public void Print()
    {
        Console.WriteLine($"{FileName} print...");
    }
}