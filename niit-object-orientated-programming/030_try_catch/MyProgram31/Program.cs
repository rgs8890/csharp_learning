using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram31
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Start"); // code to connect to the database
                int x, y, z;
                Console.Write("Enter a number : ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter a number : ");
                y = Convert.ToInt32(Console.ReadLine());
                z = x / y;
                Console.WriteLine("The Result is : " + z);
                // code to commit 
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Please Dont Divide By Zero");
                // code to rollback 
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Please Input Integer Values Only");
                // code to rollback 
            }
            finally
            {
                Console.WriteLine("Happy Ending");// code to close the DB
            }
            Console.ReadKey();
        }
    }
}
