using System;
using System.Diagnostics;
using System.Runtime.InteropServices.JavaScript;
using System.Text;

namespace FirstProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Person bill = new Person("Bill", "Koko");


            bill.SetDateOfBirth(new DateTime(1990, 1, 1));


            bill.SayHi();
            Person john = new Person("John", "Wick", new DateTime(2000, 3, 4));
            john.ContactNumber = "111111111111";
            john.SayHi();
        }
    }
}