using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] x = new int[3,3];
            int i, j;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("Enter a number : ");
                    x[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The Matrix is....");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("\t"+x[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
