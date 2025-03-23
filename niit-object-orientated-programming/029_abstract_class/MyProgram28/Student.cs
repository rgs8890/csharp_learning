using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram28
{
    class Student : Person
    {
        int rollno, std, marks;

        public void getData()
        {
            Console.Write("Enter Rollno : ");
            rollno = Convert.ToInt32(Console.ReadLine());
            accept();
            Console.Write("Enter Std : ");
            std = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Marks : ");
            marks = Convert.ToInt32(Console.ReadLine());
        }

        public override void display()
        {
            Console.WriteLine("Rollno : " + rollno);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Gender : " + gender);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Std : " + std);
            Console.WriteLine("Marks : " + marks);
        }
    }
}
