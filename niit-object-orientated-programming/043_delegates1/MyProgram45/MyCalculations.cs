using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram45
{
    class MyCalculations
    {
        public void sum(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("({0} + {1}) = {2}", a, b, c);
        }

        public void subtract(int a, int b)
        {
            int c = a - b;
            Console.WriteLine("({0} - {1}) = {2}", a, b, c);
        }
    }
}
