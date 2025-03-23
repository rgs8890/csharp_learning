using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram39
{
    class Program
    {
        static void Main(string[] args) //Using List for Generics
        {
            List<int> ls = new List<int>();
            ls.Add(10);
            ls.Add(20);
            ls.Add(50);
            ls.Add(30);
            ls.Add(90);
            ls.Add(40);

            foreach (int n in ls)
            {
                Console.WriteLine("No : " + n);
            }
            Console.ReadKey();
        }
    }
}
