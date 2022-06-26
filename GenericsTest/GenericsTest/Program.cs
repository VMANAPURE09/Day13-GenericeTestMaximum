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
            GenericMaximum<int> maximum = new GenericMaximum<int>(num1, num2, num3);
            int max = maximum.MaxMethod();
            Console.WriteLine(max +" is Maximum Value");
        }
    }
}
