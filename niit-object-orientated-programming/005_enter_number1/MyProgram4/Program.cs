using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Enter a number : ");
            x = Convert.ToInt32(Console.ReadLine());
            if(x > 0)
            {
                Console.WriteLine("Number is +ve");
            }
            else
            {
                Console.WriteLine("Number is -ve");
            }
            Console.ReadKey();
        }
    }
}
