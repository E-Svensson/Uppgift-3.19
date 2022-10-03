using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en addition eller en subtraktion så att programmet får lösa den själv.");
            Console.WriteLine("T.ex. \"21+23\" eller \"35-14\".");
            Console.WriteLine(" ");

            Console.Write("Skriv här: "); string input = Console.ReadLine();
            Console.WriteLine(" ");

            string[] input2 = input.Split('+', '-');

            double tal1 = double.Parse(input2[0]);
            double tal2 = double.Parse(input2[1]);

            if (input.Contains("+"))
            {
                double svar1 = tal1 + tal2;

                Console.WriteLine($"Ditt svar blir: {svar1} ");
            }

            else if (input.Contains("-"))
            {
                double svar2 = tal1 - tal2;

                Console.WriteLine($"Ditt svar blir: {svar2} ");
            }

            else
            {
                Console.WriteLine("Nu har du gjort något fel och programmet fucka.");
            }
        }
    }
}
