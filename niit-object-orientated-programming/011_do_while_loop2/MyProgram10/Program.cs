using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram10
{
    class Program
    {
        static void Main(string[] args)
        {
            String wish;
            double x, y, z;
            do
            {
                Console.Write("Enter a number : ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter a number : ");
                y = Convert.ToDouble(Console.ReadLine());
                z = x + y;
                Console.WriteLine("The Addition of {0} and {1} is {2}", x, y, z);
                Console.Write("Do You Wish To Continue... [y/n] : ");
                wish = Console.ReadLine();
            } while (wish.Equals("y") || wish.Equals("Y"));
            Console.ReadKey();
        }
    }
}