using System;

namespace QuotientRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int dividend , divisor ;
            Console.WriteLine("enter the dividend:");
            dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the divisor:");
            divisor = Convert.ToInt32(Console.ReadLine());
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
        }
    }
}
