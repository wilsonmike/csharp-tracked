using System;

namespace functions
{
    class Program
    {
        static void TimesTable(byte number)
        {
            Console.WriteLine($"This is the {number} times table:");
            for (int row = 1; row <= 12; row++)
            {
                Console.WriteLine($"{row} x {number} = {row * number}");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
