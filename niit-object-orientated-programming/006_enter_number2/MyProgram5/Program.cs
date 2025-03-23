using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// This program is to check whether the number is odd or even
/// </summary>
namespace MyProgram5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Enter a number : ");
            x = Convert.ToInt32(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
            Console.ReadKey();
        }
    }
}
