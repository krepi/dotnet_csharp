namespace FirstProject;

public interface IFile
{
    string FileName { get; set; }
     int Size { get; set; }
     DateTime CreatedOn { get; set; }

     void Compress();


}