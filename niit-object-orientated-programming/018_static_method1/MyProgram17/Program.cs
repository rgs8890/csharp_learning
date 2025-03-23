using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram17
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
            z = add(x, y);
            Console.WriteLine("The Result is " + z);
            Console.ReadKey();
        }

        static int add(int a, int b)
        {
            int c;
            c = a + b;
            return c;
        }

        
    }
}
