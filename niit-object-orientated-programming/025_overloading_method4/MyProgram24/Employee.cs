using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram24
{
    class Employee : Person
    {
        int empid, salary;
        String desig;


        public void input()
        {
            Console.Write("Enter Empid : ");
            empid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Designation : ");
            desig = Console.ReadLine();
            Console.Write("Enter Salary : ");
            salary = Convert.ToInt32(Console.ReadLine());
        }

        public void output()
        {
            Console.WriteLine("Empid : " +empid);
            Console.WriteLine("Designation : " +desig);
            Console.WriteLine("Salary : " +salary);
        }
    }
}
