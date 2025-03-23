using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MyProgram37
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Console.WriteLine("Array List Capacity : " + al.Capacity);
            al.Add(10);
            al.Add(40);
            al.Add(80);
            al.Add(50);
            al.Add(30);
            al.Add(90);
            al.Add(70);
            al.Add(20);
            al.Add(15);
            al.Add(20);
            al.Add(35);

            Console.WriteLine("Array List Capacity : " + al.Capacity);
            Console.WriteLine("Array List Size : " + al.Count);

            for(int i=0;i<al.Count;i++) // Using general for loop
            {
                Console.WriteLine("Item : " + al[i]);
            }

            foreach (int n in al) // using foreach loop
            {
                Console.WriteLine("Item : " + n);
            }

            if (al.Contains(20))
            {
                Console.WriteLine("The Alphabet Exists at : " + al.IndexOf(20));
            }
            else
            {
                Console.WriteLine("Not Available In List");
            }

            //To Store data of different data types
            ArrayList al2 = new ArrayList();
            al2.Add(1001);
            al2.Add("Raj");
            al2.Add("Male");
            al2.Add(26);


            for (int i = 0; i < al2.Count; i++)
            {
                Console.WriteLine("Item : " + al2[i]);
            }



            ArrayList al3 = new ArrayList();
            al3.Add("India");
            al3.Add("China");
            al3.Add("Japan");
            al3.Add("Srilanka");
            al3.Add("Nepal");
            al3.Add("America");
            al3.Add("Spain");

            Console.WriteLine("Before Sorting");
            foreach (String a in al3)
            {
                Console.WriteLine("Item : " + a);
            }

            al3.Sort();
            al3.Reverse();


            Console.WriteLine("After Sorting");
            foreach (String a in al3)
            {
                Console.WriteLine("Item : " + a);
            }
            Console.ReadKey();

            
        }
    }
}
