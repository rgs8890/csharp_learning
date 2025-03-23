using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram27
{
    class Program
    {
        static void Main(string[] args)
        {
            Box3D b = new Box3D();
            b.accept();
            b.display();

            Console.ReadKey();
        }
    }
}
