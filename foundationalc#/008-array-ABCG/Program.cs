using System;

namespace TestProject8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = { "B123", "C234", "A345" , "C15", "B177", "G3003", "C235", "B179" };

            foreach (string orderId in myArray)
            {
                if (orderId.StartsWith("B"))
                {
                    Console.WriteLine($"{orderId} starts with 'B'!");
                }
            }
        }
    }
}