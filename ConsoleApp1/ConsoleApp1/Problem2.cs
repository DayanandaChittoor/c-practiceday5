using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Problem2
    {
        static void Main(string[] args)
        {
            int dividend = 90, divisor = 9;
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("dividend : " + dividend );
            Console.WriteLine("divisor : " + divisor );
            Console.WriteLine("quotient = " + quotient);
            Console.WriteLine("remainder + " + remainder);


        }
    }
}
