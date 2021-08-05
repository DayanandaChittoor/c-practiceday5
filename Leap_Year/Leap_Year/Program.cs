using System;

namespace Leap_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Year to check whether it is Leap year or not ");
            int year = int.Parse(Console.ReadLine());

            if ( year%4 == 0)
            {
                Console.WriteLine(year + " is a Leap year");
            }
            else
            {
                Console.WriteLine(year + " is not a Leap year");
            }
        }
    }
}
