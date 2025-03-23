using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[10];
            for (int i = 0; i <= 9; i++)
            {
                Console.Write("Enter a number : ");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Numbers From Last 2 First...");
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine("No : " + x[i]);
            }
            Console.ReadKey();
        }
    }
}
