using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices.JavaScript;
using System.Text;

namespace FirstProject
{
    internal class Program
    {
        static void DisplayElements(List<int> list)
        {
            Console.WriteLine("** List **");
            foreach (int element in list)
            {
                Console.Write($"{element},");
            }
            Console.WriteLine(" ");
            Console.WriteLine("** End **");
        }
        private static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            int arrayLength = intArray.Length; // 5

            List<int> intList = new List<int>(){6,1,20, 3, 45, 100, 2};
            
            Console.WriteLine("New element");
            string userInput = Console.ReadLine();
            int intValue = int.Parse(userInput);
            
            intList.Add(intValue);
            DisplayElements(intList);
            intList.Sort();
            DisplayElements(intList);


        }
    }
}