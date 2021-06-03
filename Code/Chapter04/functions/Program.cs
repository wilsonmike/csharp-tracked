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
        static void RunTimesTable()
        {
            bool isNumber;
            do
            {
                Console.WriteLine("Enter a number between 0 and 255: ");
                isNumber = byte.TryParse(Console.ReadLine(), out byte number);
                if (isNumber)
                {
                    TimesTable(number);
                }
                else
                {
                    Console.WriteLine("You did not enter a valid number!");
                }
            }
            while (isNumber);
        }
        static void Main(string[] args)
        {
            RunTimesTable();
        }
    }
}
