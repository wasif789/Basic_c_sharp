using System;

namespace PowerOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the power till you want the table of 2");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= N; i++)
            {
                Console.WriteLine("2 to the power of {0} is"+Math.Pow(2, i),i);
            }
        }
    }
}
