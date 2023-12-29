using System;
using System.Diagnostics;
using System.Runtime.InteropServices.JavaScript;
using System.Text;

namespace FirstProject
{
    internal class Program
    {
        public class GradeCalculator
        {
            public static string CalculateGrade(double percentage)
            {
                // przykładowy rezultat - zwracana jest ocena A
// ify - cwiczenie
                // if (percentage >= 90)
                // {
                //     return "A";
                // }
                // else if (percentage >= 80)
                // {
                //     return "B";
                // }
                // else if (percentage >= 70)
                // {
                //     return "C";
                // }
                // else if (percentage >= 60)
                // {
                //     return "D";
                // }
                // else
                // {
                //     return "F";
                // }
// cwiczenei switch?
                //     double result = 5.17;
                //     switch (hours) // must be int (hours) at method parameter instead double
                //     {
                //         case 1:
                //             result = 5;
                //             break;
                //         
                //         default: result = 5 + (hours-1) * 3;
                //             break;
                //     }
                //
                //     return result.ToString();
                // }
                return "1";
            }

            static int solveMeFirst(int a, int b) { 
                int sum = 0;
                if(a >=1 && a<=1000 &&  b >=1 && b<=1000)
                
                {  
                    sum = a + b;
                }
                return sum;
            }
            private static void Main(string[] args)
            {
                
                
                
                // if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
                //     Console.WriteLine("today is Monday");
                // else if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
                //     Console.WriteLine("today is Tuesday");
                // else if (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday) Console.WriteLine("today is Wedn");


                // string userInput = Console.ReadLine();
                // int yearOfBirth;
                // if (int.TryParse(userInput, out yearOfBirth))
                // {
                //     int age = DateTime.Now.Year - yearOfBirth;
                //     Console.WriteLine("your age is " + age);
                // }
                // else
                // {
                //     Console.WriteLine("podaj licbe roku baranie");
                // }
// kalkulator BMI

                // Console.WriteLine("give your height (m) :");
                // string userHeightInput = Console.ReadLine();
                // double userHeight;
                // double userWeight;
                // double bmi = 0.0d;
                //
                // Console.WriteLine("give your weight (kg) :");
                // string userWeightInput = Console.ReadLine();
                //
                // if (double.TryParse(userHeightInput, out userHeight) && double.TryParse(userWeightInput, out userWeight))
                // {
                //     bmi = userWeight / (userHeight * userHeight);
                //     string sentence;
                //     if (bmi > 35)
                //     {
                //         sentence = "fattolus";
                //     }
                //     else if (bmi > 25)
                //     {
                //         sentence = "fattie";
                //     }
                //     else if (bmi > 18.5)
                //     {
                //         sentence = " normal";
                //     } else
                //     {
                //         sentence = "skinny";
                //     }
                //     
                //     Console.WriteLine("your BMI is : " + bmi + " you are " + sentence + " chika");
                // }
                // else
                // {
                //     Console.WriteLine("your input was not correct, check your height and weight an d back again ");
                // }
              
            }
        }
    }
}