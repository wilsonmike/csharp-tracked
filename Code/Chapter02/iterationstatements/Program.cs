using System;

namespace iterationstatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while (x < 10)
            {
                Console.WriteLine(x);
                x++;
            }

            string password = string.Empty;
            do{
                Console.Write("Enter your password: ");
                password = Console.ReadLine();
            }
            while (password != "Pa$$w0rd");
            Console.WriteLine("Correct!");

            for (int y = 1; y <= 10; y++)
            {
                Console.WriteLine(y);
            }

            string[] names = { "Do", "You", "Know", "The", "Muffin", "Man"};
            foreach (string name in names)
            {
                Console.WriteLine($"{name} has {name.Length} characters.");
            }

            //fizzbuzz

            for (int i = 1; i < 101; i++){
                if (i % 15 == 0) {
                    Console.WriteLine("FizzBuzz");
                } else if (i % 3 == 0) {
                    Console.WriteLine("Fizz");
                } else if (i % 5 == 0) {
                    Console.WriteLine("Buzz");
                } else {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
