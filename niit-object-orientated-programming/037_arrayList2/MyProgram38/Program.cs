using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MyProgram38
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("A");
            al.Add("B");
            al.Add("C");
            al.Add("D");
            al.Add("E");
            al.Add("F");
            al.Add("G");
            al.Add("H");
            Console.WriteLine("Before Removing");
            foreach (String a in al)
            {
                Console.WriteLine("Item : " + a);
            }

            al.Remove("F");
            al.RemoveAt(4);
            al.RemoveRange(0, 3);


            Console.WriteLine("After Removing");
            foreach (String a in al)
            {
                Console.WriteLine("Item : " + a);
            }

            Console.ReadKey();
        }
    }
}
