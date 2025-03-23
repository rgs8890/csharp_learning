using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram26
{
    class Student : Person
    {
        int rollno, std, marks;

        public Student()
        {
            rollno = 1;
            std = 1;
            marks = 1;
        }

        public Student(int rollno, String name, String gender, int age, int std, int marks) : base(name, gender, age)
        {
            this.rollno = rollno;
            this.std = std;
            this.marks = marks;
        }

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

        public void showData()
        {
            Console.WriteLine("Rollno : " + rollno);
            display();
            Console.WriteLine("Std : " + std);
            Console.WriteLine("Marks : " + marks);
        }
    }
}
