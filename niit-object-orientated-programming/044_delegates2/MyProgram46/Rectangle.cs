using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram46
{
    class Rectangle
    {
        public void area(double height, double width)
        {
            Console.WriteLine("Area is: {0}", (width * height));
        }


        public void perimeter(double height, double width)
        {
            Console.WriteLine("Perimeter is: {0} ", 2 * (width + height));
        }
    }
}
