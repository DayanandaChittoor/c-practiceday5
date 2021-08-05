using System;

namespace Prime_Factors
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            Console.WriteLine("Please enter a number: ");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i*i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i + " is a factor of " + n);
                }
            }
        }
    }
}
