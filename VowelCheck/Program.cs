using System;

namespace VowelCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an alphabet to check vowel or consonent:");
            char alpha = Convert.ToChar(Console.ReadLine());
            if (alpha == 'a' || alpha == 'e' || alpha == 'i' || alpha == 'o' || alpha == 'u' || alpha == 'A' || alpha == 'E' || alpha == 'I' || alpha == 'O' || alpha == 'U')
            {
                Console.WriteLine("enetered alphabet is a vowel");
            }
            else
            {
                Console.WriteLine("entered alphabet is a consonent");
            }
        }
    }
}
