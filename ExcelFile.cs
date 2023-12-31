namespace FirstProject;

public class ExcelFile : IFile
{
  

    public void GenerateReport()
    {
        Console.WriteLine($"{FileName} report...");
    }


    public string FileName { get; set; }
    public int Size { get; set; }
    public DateTime CreatedOn { get; set; }

    public  void Compress()
    {
        Console.WriteLine("Compressing Excel");
    }
}