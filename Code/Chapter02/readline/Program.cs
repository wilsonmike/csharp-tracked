using System;

namespace readline
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type your first name and press ENTER: ");
            string firstName = Console.ReadLine();
            Console.Write("Type your age and press ENTER: ");
            string age = Console.ReadLine();
            Console.WriteLine($"Hello {firstName}, you look great for {age}.");
        }
    }
}
