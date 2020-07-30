using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingRepeats
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj pierwszą liczbę: ");
            var number1 = Console.ReadLine();
            Console.Write("Podaj drugą liczbę: ");
            var number2 = Console.ReadLine();

            if (int.TryParse(number1, out int result1) && int.TryParse(number2, out int result2))
            {
                Console.Write("Podane liczby spełniają założenia: ");

                if (ComparingNumbers.CompareNumbers(number1, number2))
                {
                    Console.WriteLine("Prawda");
                }
                else
                    Console.WriteLine("Fałsz");
            }
            else
            {
                Console.WriteLine("Wprowadzono nieprawidłowe dane");
            }

            Console.ReadLine();
        }
    }
}
