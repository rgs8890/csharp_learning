using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MyProgram43
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue("Apple");
            q.Enqueue("Banana");
            q.Enqueue("Cherry");
            q.Enqueue("Mango");
            q.Enqueue("Chikku");
            q.Enqueue("Gava");
            q.Enqueue("Grapes");

            foreach (String f in q)
            {
                Console.WriteLine("Fruit : " + f);
            }

            q.Dequeue();

            Console.WriteLine("After Removing An Element");
            foreach (String f in q)
            {
                Console.WriteLine("Fruit : " + f);
            }
            Console.ReadKey();
        }
    }
}
