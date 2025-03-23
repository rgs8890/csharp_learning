using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, rev=0, rem, m;
            Console.Write("Enter a number : ");
            n = Convert.ToInt32(Console.ReadLine());
            m = n;
            while(n>0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n = n / 10;
            }
            Console.WriteLine("The Reverse of digits {0} is {1}", m, rev);
            Console.ReadKey();
        }
    }
}
