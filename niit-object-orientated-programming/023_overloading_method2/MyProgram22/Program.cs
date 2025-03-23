using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram22
{
    class Program
    {
        static void Main(string[] args)
        {
            double i, j, k;
            Calculations c = new Calculations();
            Console.Write("Enter a number : ");
            i = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a number : ");
            j = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a number : ");
            k = Convert.ToDouble(Console.ReadLine());

            c.add(i, j, k);

            Console.ReadKey();
        }
    }
}
