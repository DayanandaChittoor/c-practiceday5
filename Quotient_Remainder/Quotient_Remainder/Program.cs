using System;

namespace Quotient_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter dividend");
            int dividend = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Divisor");
            int divisor = int.Parse(Console.ReadLine());
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("dividend : " + dividend);
            Console.WriteLine("divisor : " + divisor);
            Console.WriteLine("quotient = " + quotient);
            Console.WriteLine("remainder = " + remainder);
        }
    }
}
