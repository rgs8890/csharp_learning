using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram25
{
    class ColorBox : Box3D
    {
        String color;

        public void getInfo()
        {
            getData();
            Console.Write("Enter Color to Paint : ");
            color = Console.ReadLine();
        }

        public void showInfo()
        {
            showData();
            Console.WriteLine("Color : " + color);
        }
    }
}
