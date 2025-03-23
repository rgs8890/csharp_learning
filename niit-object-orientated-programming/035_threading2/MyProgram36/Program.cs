using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MyProgram36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start of Main Thread..");
            BasicThread bt = new BasicThread();
            ThreadStart ts1 = new ThreadStart(bt.fun1);
            ThreadStart ts2 = new ThreadStart(bt.fun2);
            Thread t1 = new Thread(ts1);
            Thread t2 = new Thread(ts2);

            t1.Start();
            t2.Start();
            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine("Main Function value : " + i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("End of Main Thread..");
            Console.ReadKey();
        }
    }
}
