using System;

namespace TestProject9
{
    class Program
    {
        static void Main(string[] args)
        { 
            string firstName = "Bob";
            int widgetsSold = 7;
            Console.WriteLine($"{firstName} purchased {widgetsSold} widgets!");

            /*
            string firstName = "Bob";
            int widgetsSold = 7;
            Console.WriteLine(firstName + " purchased " + widgetsSold + " widgets!");
            */

            Random random = new Random();
            string[] orderIDs = new string[5];

            for (int i = 0; i < orderIDs.Length; i++)
            {
                int prefixValue = random.Next(65, 70);
                string prefix = Convert.ToChar(prefixValue).ToString();
                string suffix = random.Next(1, 1000).ToString("000");
                orderIDs[i] = prefix + suffix;
            }

            foreach (var orderID in orderIDs)
            {
                Console.WriteLine(orderID);
            }

            Console.WriteLine("Hello Example 1!");

            string firstWord="Hello";
            string lastWord="Example 2";
            Console.WriteLine(firstWord+" "+lastWord+"!");
        }
    }
}