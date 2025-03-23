using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.Write("Enter a number : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number : ");
            y = Convert.ToInt32(Console.ReadLine());
            z = x + y;
            Console.WriteLine("Addition of " + x + " and " + y + " is " + z);
            Console.WriteLine("Addition of {0} and {1} is {2}", x, y, z);
            Console.ReadKey();
        }
    }
}
