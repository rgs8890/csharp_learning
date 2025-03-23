using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MyProgram36
{
    class BasicThread
    {
        public void fun1()
        {
            Console.WriteLine("Start Of Function 1");
            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine("Function 1 Value : " + i);
                Thread.Sleep(500);
            }
            Console.WriteLine("End of Function 1");
        }

        public void fun2()
        {
            Console.WriteLine("Start Of Function 2");
            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine("Function 2 Value : " + i);
                Thread.Sleep(500);
            }
            Console.WriteLine("End of Function 2");
        }
    }
}
