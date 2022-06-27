using System;

namespace GenericsTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 30;
            int num3 = 20;
            MaximumNumber max = new MaximumNumber();
            int maxNumber = max.ReturnMaxNumber(num1, num2, num3);
            Console.WriteLine("max number is " + maxNumber);

        }
    }
}
