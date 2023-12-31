using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices.JavaScript;
using System.Text;

namespace FirstProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ExcelFile excelFile = new ExcelFile();
            excelFile.CreatedOn = DateTime.Now;
            excelFile.FileName = "excel-file";
            excelFile.GenerateReport();

            WordFile wordFile = new WordFile();
            wordFile.FileName = "word-file";
            wordFile.CreatedOn = DateTime.Now;

            wordFile.Print();

            PowerPointFile powerPointFile = new PowerPointFile();
            powerPointFile.FileName = "power-point presentation";
            powerPointFile.CreatedOn = DateTime.Now;
            
            powerPointFile.Present();
            Console.WriteLine($"Starting the car:  {wordFile.FileName} z dupska");

            Shape[] shapes = {new Rectangle(), new Circle(), new Triangle() };

            foreach (Shape shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}