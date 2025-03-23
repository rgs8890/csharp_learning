using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram25
{
    class Box3D : Box
    {
        int hig;

        public void getData()
        {
            accept();
            Console.Write("Enter Height : ");
            hig = Convert.ToInt32(Console.ReadLine());
        }

        public void showData()
        {
            display();
            Console.WriteLine("Height : " + hig);
        }

        public void volume()
        {
            int v = area() * hig;
            Console.WriteLine("Volume : " + v);
        }
    }
}
