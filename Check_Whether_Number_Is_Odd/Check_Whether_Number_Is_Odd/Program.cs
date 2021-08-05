using System;

namespace Check_Whether_Number_Is_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check it is even or odd");
            int number = int.Parse(Console.ReadLine());
            if (number%2 == 0)
            {
                Console.WriteLine(number + "Number is Even");
            }
            else
            {
                Console.WriteLine(number + " Number is odd");
            }
        }
    }
}
