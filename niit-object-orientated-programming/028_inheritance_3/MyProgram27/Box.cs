using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram27
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

        public void display()
        {
            Console.WriteLine("Lenght : " + len);
            Console.WriteLine("Breadth : " + bre);
        }
    }
}
