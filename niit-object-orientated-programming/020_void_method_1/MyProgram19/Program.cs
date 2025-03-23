using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram19
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.input();
            s1.calcResult();
            s1.showData();

            Console.ReadKey();
        }
    }
}
