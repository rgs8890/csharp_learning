using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[10];
            int i, j, temp;
            for (i = 0; i < 10; i++)
            {
                Console.Write("Enter a number : ");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < 10; i++)
            {
                for (j = i + 1; j < 10; j++)
                {
                    if(x[i]>x[j])
                    {
                        temp = x[i];
                        x[i] = x[j];
                        x[j] = temp;
                    }
                }
            }
            Console.WriteLine("Numbers in ascending order are...");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("No : " + x[i]);
            }
            Console.ReadKey();
        }
    }
}
