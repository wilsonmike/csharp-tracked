﻿using System;

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
        }
    }
}
