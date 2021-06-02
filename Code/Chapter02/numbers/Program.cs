using System;

namespace numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // positive whole number
            uint naturalNumber = 23;
            // negative or positive whole number
            int integerNumber = -23;
            // single precision floating point
            float realNumber = 2.3F;
            // double precision floating point
            double anotherRealNumber = 2.3;

            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers");
            Console.WriteLine($"uint uses {sizeof(uint)} bytes and can store numbers");
            Console.WriteLine($"float uses {sizeof(float)} bytes and can store numbers");
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers");
        }
    }
}
