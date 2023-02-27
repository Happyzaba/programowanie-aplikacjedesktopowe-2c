using System;
using System.Runtime.Intrinsics.Arm;

namespace ExceptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int firstNumber, secondNumber, divNumber;
             
                Console.WriteLine("Podaj pierwszą liczbę");
                firstNumber = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Podaj drugą liczbę");
                secondNumber = int.Parse(Console.ReadLine());

                divNumber = firstNumber / secondNumber;

                Console.WriteLine("Wynik dzielenia: " + divNumber);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
