using System;

namespace Powers_Of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to print Powers of Two");
            int n = int.Parse(Console.ReadLine());
            int a = 1;
    
            if (n <= 31 )
            {
                for (int i = 0; i <= n; i++)
                {
                    a = a * 2;
                    Console.WriteLine(a);
                }
            }
        }
    }
}
