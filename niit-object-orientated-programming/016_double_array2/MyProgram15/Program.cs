using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] x = new int[3, 3];
            int[,] y = new int[3, 3];
            int[,] z = new int[3, 3];
            
            int i, j;
            Console.WriteLine("Enter Values Fox X Matrix....");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("Enter a number : ");
                    x[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter Values Fox Y Matrix....");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("Enter a number : ");
                    y[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }


            
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    z[i, j] = x[i, j] + y[i, j];
                }
            }

            Console.WriteLine("The X Matrix is....");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("\t" + x[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("The Y Matrix is....");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("\t" + y[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("The Resultant Matrix is....");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("\t" + z[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
