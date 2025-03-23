using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram21
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(1001, "Rajinesh", "M", 15, 10, 67, 67, 66);
            Student s2 = new Student(s1);

            s1.calcResult();
            s2.calcResult();

            s1.showData();
            s2.showData();

            Console.ReadKey();
        }
    }
}
