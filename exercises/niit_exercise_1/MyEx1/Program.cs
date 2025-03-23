using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int even_numbers = 0;
            int odd_numbers = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter a number : ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    even_numbers++;
                }
                else
                {
                    odd_numbers++;
                }

            }
            Console.WriteLine("The number of even numbers is " + even_numbers);
            Console.WriteLine("The number of odd numbers is " + odd_numbers);
            Console.ReadKey();
        }
    }
}
