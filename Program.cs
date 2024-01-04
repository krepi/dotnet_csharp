using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices.JavaScript;
using System.Text;

namespace FirstProject
{
    
    internal class Program
    {
        static void Double(ref int value)
        {
            value *= 2;
            Console.WriteLine($"Doubled value = {value}");
        }

        static bool isDivisible(int value, int factor, out int reminder )
        {
            reminder = value % factor;
            return reminder == 0;
        }
        static void ConvertCelsiusToFahrenheit(double celsius, out double fahrenheit)
        {
            fahrenheit = celsius *1.8 +32;
           
            
                
            
            {
                
            }
            // todo
        }
    
        static void ConvertFahrenheitToCelsius(double fahrenheit, ref double celsius)
        {
            // todo
            celsius = (fahrenheit - 32) / 1.8;
        }

        static void TryNumber(string number, out int ujemna)
        {
            ujemna = 0;
            int checking;
            if (int.TryParse(number, out checking) != false)
            {
                if (checking < 0)
                {
                    ujemna = checking;
                }
            }
            Console.WriteLine($"ujemna = {ujemna}");
        }
        
        
        private static void Main(string[] args)
        {
            int someValue = 5;
            Double(ref someValue);
            Console.WriteLine($"some value = {someValue}");

            int value = 5;
            int factor = 2;
            int reminder;
            if (isDivisible(value, factor, out reminder))
            {
                Console.WriteLine("is divided");
            }
            else
            {
                Console.WriteLine($"isnt divided by {factor}. reminder: {reminder}");
            }

            int ujemna;
            TryNumber("-333", out ujemna);
        }
    }
}