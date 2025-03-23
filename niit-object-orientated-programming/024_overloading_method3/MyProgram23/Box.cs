using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram23
{
    class Box
    {
        int len, bre;

        public void accept()
        {
            Console.Write("Enter Length : ");
            len = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Breadth : ");
            bre = Convert.ToInt32(Console.ReadLine());
        }

        public void calc()
        {
            int a;
            a = len * bre;
            Console.WriteLine("Area : " + a);
        }

        public void display()
        {
            Console.WriteLine("Lenght : " + len);
            Console.WriteLine("Breadth : " + bre);
        }

        public Box add(Box x)
        {
            Box z = new Box();
            z.len = len + x.len;
            z.bre = bre + x.bre;
            return z;
        }

        public static Box operator +(Box x, Box y)
        {
            Box z = new Box();
            z.len = x.len + y.len;
            z.bre = x.bre + y.bre;
            return z;
        }

    }
}
