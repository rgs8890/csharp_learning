using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram23
{
    class Program
    {
        static void Main(string[] args)
        {
            Box b1 = new Box();
            Box b2 = new Box();
            Box b3 = new Box();

            b1.accept();
            b2.accept();

            Console.WriteLine();
            b1.display();
            b1.calc();

            Console.WriteLine();
            b2.display();
            b2.calc();

            Console.WriteLine();
            b3 = b1 + b2;
            b3.display();
            b3.calc();

            Console.ReadKey();
        }
    }
}