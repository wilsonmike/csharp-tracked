using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names;
            names = new string[4];
            names[0] ="Jack";
            names[1] = "Jill";
            names[2] = "Gingerbread";
            names[3] = "Man";

            for (int i = 0; i <names.Length; i++) {
                Console.WriteLine(names[i]);
            }
        }
    }
}
