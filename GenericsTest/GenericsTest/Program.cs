using System;

namespace GenericsTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 16;
            int num2 = 22;
            int num3 = 32;
            MaximumNumber max = new MaximumNumber();
            int maxNumber = max.ReturnMaxNumber(num1, num2, num3);
            Console.WriteLine("max number is " + maxNumber);
        }
    }
}
