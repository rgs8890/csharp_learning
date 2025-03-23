using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram25
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorBox c = new ColorBox();
            c.getInfo();
            c.showInfo();
            c.volume();

            Console.ReadKey();
        }
    }
}
