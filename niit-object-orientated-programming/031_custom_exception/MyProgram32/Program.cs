using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram32
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person p = new Person();
                p.accept();
                p.display();
            }
            catch(InvalidAgeException ex)
            {
                Console.WriteLine("Please Do Check The Age Again...");
            }

            Console.ReadKey();
        }
    }
}
