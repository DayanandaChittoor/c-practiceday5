using System;

namespace To_check_Letter_Is_Vowel_Or_Consonant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Letter to Check whether it is Vowel or Consonant");
            char letter = char.Parse(Console.ReadLine().ToLower());

            switch (letter)
            {
                case 'a':
                    Console.WriteLine(letter + " is a Vowel");
                    break;
                case 'e':
                    Console.WriteLine(letter + " is a Vowel");
                    break;
                 case 'i':
                    Console.WriteLine(letter + " is a Vowel");
                    break;
                case '0':
                    Console.WriteLine(letter + " is a Vowel");
                    break;
                case 'u':
                    Console.WriteLine(letter + " is a Vowel");
                    break;
                default :
                    Console.WriteLine(letter + " is a consonant");
                    break;
            }

        }
    }
}
