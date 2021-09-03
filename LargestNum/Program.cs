using System;

namespace LargestNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the third number:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("{0} is the largest number.", num1);
            }
            if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("{0} is the largest number.", num2);
            }
            if (num3 >= num1 && num3 >= num2)
            {
                Console.WriteLine("{0} is the largest number.", num3);
            }
        }
    }
}
