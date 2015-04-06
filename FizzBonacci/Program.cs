using System;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        const int totalCount = 10;

        static void Main(string[] args)
        {
            // Adding a comment to prove I can.
            Console.WriteLine("Press any key to get the first 10 Fibbonacci numbers!");
            Console.ReadKey();

            var fizzBuzzinator = new FizzBuzzinator();
            var sequence = fizzBuzzinator.Generate(totalCount);
            Console.WriteLine();
            Console.WriteLine(String.Join(", ", sequence.ToArray()));
            Console.WriteLine();
            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();
            Console.WriteLine("QUITTER!");
        }
    }
}
