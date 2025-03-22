using System;

namespace TestProject10
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "The quick brown fox jumps over the lazy dog.";

            char[] charMessage = str.ToCharArray();

            Array.Reverse(charMessage);

            int x = 0;
            int y = 0;

            foreach (char c in charMessage)
            {
                
                if (c == 'o')
                {
                    x++;
                }
                else 
                {   
                    y++;
                }
            }

            string new_message = new string(charMessage);

            Console.WriteLine(new_message);
            Console.WriteLine($"'o' appears {x} times.");   
            Console.WriteLine($"'o' does not appear {y} times.");     
        }
    }
}