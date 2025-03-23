using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram41
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<String> ll = new LinkedList<string>();

            ll.AddLast("India");
            ll.AddLast("China");
            ll.AddLast("Japan");
            ll.AddLast("Srilanka");
            ll.AddLast("Nepal");
            ll.AddLast("Spain");
            ll.AddLast("England");

            Console.WriteLine("Before Removing....");
            foreach (String c in ll)
            {
                Console.WriteLine("Country Name : " + c);
            }

            ll.Remove("Nepal");

            Console.WriteLine("After Removing....");
            foreach (String c in ll)
            {
                Console.WriteLine("Country Name : " + c);
            }


            ll.AddBefore(ll.Find("Spain"), "Germany");
            Console.WriteLine("Adding Germany After Spain....");
            foreach (String c in ll)
            {
                Console.WriteLine("Country Name : " + c);
            }

            Console.ReadKey();
        }
    }
}
