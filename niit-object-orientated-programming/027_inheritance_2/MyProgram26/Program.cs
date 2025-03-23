using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram26
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(1001, "Raj","Male",15, 10, 560);
            s.showData();

            Console.ReadKey();
        }
    }
}
