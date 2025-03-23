using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MyProgram42
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push("India");
            s.Push("China");
            s.Push("Srilanka");
            s.Push("Nepal");
            s.Push("Canada");
            s.Push("Spain");

            foreach (String c in s)
            {
                Console.WriteLine("Country : " + c);
            }

            s.Pop();
            Console.WriteLine("After Popping The Top");
            foreach (String c in s)
            {
                Console.WriteLine("Country : " + c);
            }

            Console.ReadKey();
        }
    }
}
