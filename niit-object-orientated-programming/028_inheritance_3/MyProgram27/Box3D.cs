using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram27
{
    class Box3D : Box
    {
        int hig;

        
        public void accept()
        {
            Console.Write("Enter Height : ");
            hig = Convert.ToInt32(Console.ReadLine());
        }

        public void display()
        {
            Console.WriteLine("Height : " + hig);
        }
    }
}
