using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            do
            {
                Console.Write("Enter a number (0 to stop) : ");
                n = Convert.ToInt32(Console.ReadLine());
                sum = sum + n;
            } while (n != 0);
            Console.WriteLine("The Sum is " + sum);
            Console.ReadKey();
        }
    }
}
