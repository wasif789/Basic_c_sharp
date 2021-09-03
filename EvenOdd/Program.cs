using System;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number to check even or odd:");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n%2==0)
            {
                Console.WriteLine("the entered number is even");
            }
            else
            {
                Console.WriteLine("the entered number is odd");
            }
        }
    }
}
