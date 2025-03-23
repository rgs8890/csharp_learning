using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram45
{
    class Program
    {
        public delegate void addnum(int a, int b);
        public delegate void subnum(int a, int b);

        static void Main(string[] args)
        {
            MyCalculations m = new MyCalculations();

            addnum an = new addnum(m.sum);
            subnum sn = new subnum(m.subtract);

            an(100, 200);
            sn(300, 120);
            Console.ReadKey();
        }
    }
}
