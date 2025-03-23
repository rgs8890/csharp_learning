using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MyProgram35
{
    class Program
    {
        static void Main(string[] args) /// program to create a thread and name the thread
        {
            Thread th = Thread.CurrentThread;
            Console.WriteLine("Thread Name : " + th.Name);
            th.Name = "MyMainThread";
            Console.WriteLine("Thread Name : " + th.Name);
            Console.ReadKey();
        }
    }
}
