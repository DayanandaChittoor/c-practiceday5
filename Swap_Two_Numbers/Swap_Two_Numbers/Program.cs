using System;

namespace Swap_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Before Swapping First Number is " + a + " Second Number is " + b);
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("After Swapping First Number is " + a + " Second Number is " + b);
        }
    }
}
