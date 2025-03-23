using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram21
{
    class Student
    {
        int rollno, age, grade, sub1, sub2, sub3;
        String name, gender, result;
        double total, avg;


        public Student()
        {
            rollno = 1;
            name = "pappu";
            gender = "m";
            age = 1;
            grade = 1;
            sub1 = 1;
            sub2 = 1;
            sub3 = 1;
        }

        public Student(int r, String n, String g, int a, int gr, int s1, int s2, int s3)
        {
            rollno = r;
            name = n;
            gender = g;
            age = a;
            grade = gr;
            sub1 = s1;
            sub2 = s2;
            sub3 = s3;
        }

        public Student( String n, String g, int r,  int a, int gr, int s1, int s2, int s3)
        {
            rollno = r;
            name = n;
            gender = g;
            age = a;
            grade = gr;
            sub1 = s1;
            sub2 = s2;
            sub3 = s3;
        }

        public Student(Student x)
        {
            rollno = x.rollno;
            name = x.name;
            gender = x.gender;
            age = x.age;
            grade = x.grade;
            sub1 = x.sub1;
            sub2 = x.sub2;
            sub3 = x.sub3;
        }

        public void input()
        {
            Console.Write("Enter Rollno : ");
            rollno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name : ");
            name = Console.ReadLine();
            Console.Write("Enter Gender : ");
            gender = Console.ReadLine();
            Console.Write("Enter Age : ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Grade : ");
            grade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Sub1 Marks : ");
            sub1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Sub2 Marks : ");
            sub2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Sub3 Marks : ");
            sub3 = Convert.ToInt32(Console.ReadLine());
        }

        public void calcResult()
        {
            total = sub1 + sub2 + sub3;
            avg = total / 3;

            if (avg > 50)
            {
                result = "Pass";
            }
            else
            {
                result = "Fail";
            }
        }

        public void showData()
        {
            Console.WriteLine("Roll No : {0}", rollno);
            Console.WriteLine("Name : {0}", name);
            Console.WriteLine("Gender : {0}", gender);
            Console.WriteLine("Age : {0}", age);
            Console.WriteLine("Grade : {0}", grade);
            Console.WriteLine("Sub1 : {0}", sub1);
            Console.WriteLine("Sub2 : {0}", sub2);
            Console.WriteLine("Sub3 : {0}", sub3);
            Console.WriteLine("Total : {0}", total);
            Console.WriteLine("Average : {0}", avg);
            Console.WriteLine("Result : {0}", result);
        }
    }
}
