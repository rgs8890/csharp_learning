using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram32
{
    class InvalidAgeException : Exception
    {
        public InvalidAgeException(int age) : base()
        {
            Console.WriteLine("Not a valid human age : " + age);
        }
    }
}
