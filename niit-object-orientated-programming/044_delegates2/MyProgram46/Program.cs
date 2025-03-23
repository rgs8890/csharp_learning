using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram46
{
    class Program
    {
        public delegate void rectDelegate(double height, double width);
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();

            rectDelegate rd = r.area;
            rd += r.perimeter;

            rd(40, 60);

            Console.ReadKey();
        }
    }
}
