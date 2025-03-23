using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram24
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee e = new Employee();
            //e.accept();
            //e.input();
            //e.display();
            //e.output();

            Student s = new Student();
            s.getData();
            s.showData();

            Console.ReadKey();
        }
    }
}
