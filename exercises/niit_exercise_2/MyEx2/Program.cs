using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[3,3];
            int i, j;
            Console.WriteLine("Enter the elements of the matrix: ");
            for (i=0; i<3; i++)
            {
                for (j=0; j<3; j++)
                {
                    Console.Write("Enter a number : ");
                    myArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("The elements for the diagonal matrix are: ");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        Console.Write(myArray[i, j]+"\t");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
