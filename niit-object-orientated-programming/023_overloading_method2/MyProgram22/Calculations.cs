using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram22
{
    class Calculations
    {
        public void add(int x, int y)
        {
            int z;
            z = x + y;
            Console.WriteLine("The Result is : " + z);
        }

        public void add(double x, double y)
        {
            double z;
            z = x + y;
            Console.WriteLine("The Result is : " + z);
        }

        public void add(double x, double y, double z)
        {
            double r;
            r = x + y + z;
            Console.WriteLine("The Result is : " + r);
        }

        public void add(String x, String y)
        {
            String z;
            z = x + y;
            Console.WriteLine("The Result is : " + z);
        }
    }
}
