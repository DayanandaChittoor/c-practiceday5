using System;

namespace Largest_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers to check which is largest");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine(num1 + " is Largest");
                }
                else
                {
                    Console.WriteLine(num3 + " is Largest");
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine(num2 + " is Largest");
                }
                else
                {
                    Console.WriteLine(num3 + " is Largest");
                }
            }
        }
    }
}
