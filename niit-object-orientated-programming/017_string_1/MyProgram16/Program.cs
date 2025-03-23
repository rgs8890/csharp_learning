using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram16
{
    class Program
    {
        static void Main(string[] args)
        {
            String name1, name2;
            Console.Write("Enter Your First Name : ");
            name1 = Console.ReadLine();
            Console.Write("Enter Your Last Name : ");
            name2 = Console.ReadLine();
            //if(name1.Equals(name2))
            //{
            //    Console.WriteLine("Names Are Same");
            //}
            //else
            //{
            //    Console.WriteLine("Names Are Different");
            //}
            //Console.WriteLine("Substring of name1 is " + name1.Substring(4,3));
            //Console.WriteLine("Replace a with e : " + name1.Replace('a', 'e'));
            //Console.WriteLine("Replace a with e : " + name1.Replace("war","peace"));
            Console.WriteLine("Length of Name : " + name1.Length);
            Console.ReadKey();
        }
    }
}
