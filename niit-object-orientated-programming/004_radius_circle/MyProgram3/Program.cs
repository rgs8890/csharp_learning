using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, r, pi = 3.142;
            Console.Write("Enter the Radius ");
            r = Convert.ToDouble(Console.ReadLine());
            a = pi * r * r;
            Console.WriteLine("The Area of the circle is " + a);
            Console.ReadKey();
        }
    }
}
