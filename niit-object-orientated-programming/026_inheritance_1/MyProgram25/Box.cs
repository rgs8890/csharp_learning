using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram25
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

        public int area()
        {
            int a;
            a = len * bre;
            Console.WriteLine("Area : " + a);
            return a;
        }

        public void display()
        {
            Console.WriteLine("Lenght : " + len);
            Console.WriteLine("Breadth : " + bre);
        }
    }
}
