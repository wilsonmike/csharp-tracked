using System;

namespace NullHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int thisCannotBeNull = 4;
            // thisCannotBeNull = null;
            int? thisCouldBeNull = null;
            thisCouldBeNull = 7;
            Console.WriteLine(thisCouldBeNull);
        }
    }
}
