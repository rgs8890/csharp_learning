using System;

namespace Testproject2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("The square root of 16 is " + Math.Sqrt(16));

            int firstValue = 500;
            int secondValue = 1000;
            int largerValue = Math.Max(firstValue, secondValue);

            Console.WriteLine(largerValue);
        }
    }
}