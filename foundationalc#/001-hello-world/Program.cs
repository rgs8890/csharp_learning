using System;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Random dice = new Random();
            int roll = dice.Next(1, 7);
            Console.WriteLine(roll);

            int result = dice.Next(1, 7);
            Console.WriteLine(result);

            Console.WriteLine(dice.Next(1, 7));
            dice.Next(1, 7);

            int number = 7;
            string text = "seven";

            Console.WriteLine(number);
            Console.WriteLine();
            Console.WriteLine(text);

            Random dicex = new Random();
            int rollx = dicex.Next();
            int rollx2 = dicex.Next(101);
            int rollx3 = dicex.Next(50, 101);

            Console.WriteLine($"First roll: {rollx}");
            Console.WriteLine($"Second roll: {rollx2}");
            Console.WriteLine($"Third roll: {rollx3}");
            
            
        }
    }
}