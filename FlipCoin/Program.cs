using System;

namespace FlipCoin
{
    class Program
    {
        static void Main(string[] args)
        {
            int heads = 0;
            int tails = 0;
            Console.WriteLine("enter the number of times you want to flip");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Random random = new Random();
                int num = random.Next(0, 2);
                if (num == 0)
                {
                    Console.WriteLine("tails");
                    tails++;


                }
                else
                {
                    Console.WriteLine("heads");
                    heads++;

                }
            }
            Console.WriteLine("number of heads:" + heads);
            Console.WriteLine("number of tails:" + tails);
            int perheads = heads * 100 / n;
            Console.WriteLine("The percent of head is {0}, and percent of Tails are  {1}", perheads, 100 - perheads);
        }
    }
}
