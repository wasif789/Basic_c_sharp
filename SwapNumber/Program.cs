using System;

namespace SwapNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.WriteLine("enter first number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("first number after swap is :" + num1);
            Console.WriteLine("second number after swap is :" + num2);
        }
    }
}
