using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram20
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] s = new Student[5];
            for(int i = 0; i < 5; i++)
            {
                s[i] = new Student();
                s[i].inputData();
                s[i].calcResult();
            }
            Console.Clear();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0} Student Details... ", (i + 1));
                s[i].showData();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
