using System;

namespace selection
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("There are no arguments");
            } 
            else
            {
                Console.WriteLine("There is at least one argument.");
            }
        }
    }
}
