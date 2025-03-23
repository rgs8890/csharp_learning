using System;
using System.Collections.Generic;
using System.Numerics;

namespace lesson2
{
    class lesson2
    {
        static void Main(string[] args)
        {
            int total = 32;

            if (total > 14)
            {
                Console.WriteLine("You win!");
            }

            if (total < 15)
            {
                Console.WriteLine("Sorry, you lose.");
            }

            string message = "The quick brown fox jumps over the lazy dog.";
            bool result = message.Contains("dog");
            Console.WriteLine(message);

            if (message.Contains("fox"))
            {
                Console.WriteLine("What does the fox say?");
            }
            Console.WriteLine(result);
        }
    }
}
