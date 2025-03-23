using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("Enter number fpr x : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number for y : ");
            y = Convert.ToInt32(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine("X is Big");
            }
            else if( x==y)
            {
                Console.WriteLine("Both are same");
            }
            else
            {
                Console.WriteLine("Y is Big");
            }
            Console.ReadKey();
        }
    }
}
