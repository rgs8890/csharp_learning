using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram30
{
    class Person  
    {
        String name, gender;
        int age;

        public void getInfo()
        {
            Console.Write("Enter Name : ");
            name = Console.ReadLine();
            Console.Write("Enter Gender : ");
            gender = Console.ReadLine();
            Console.Write("Enter Age : ");
            age = Convert.ToInt32(Console.ReadLine());
        }

        public void showInfo()
        {
            Console.WriteLine("Name : " +name);
            Console.WriteLine("Gender : " +gender);
            Console.WriteLine("Age : " +age);
        }
    }
}
