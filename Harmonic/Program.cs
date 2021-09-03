using System;

namespace Harmonic
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,N;
            Console.WriteLine("enter the harmonic value: ");
            N = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= N; i++)
            {
                if (i == N)
                {
                    Console.Write("1/" + i);
                }
                else
                {
                    Console.Write("1/" + i + "+");
                }
            }

        }
    }
}
