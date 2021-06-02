using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            object height = 1.88;
            object name = "DinoMike";
            Console.WriteLine($"{name} is {height} meters tall.");
            // int length1 = name.Length;
            int length2 = ((string)name).Length;
            Console.WriteLine($"{name} has {length2} characters.");
        }
    }
}
