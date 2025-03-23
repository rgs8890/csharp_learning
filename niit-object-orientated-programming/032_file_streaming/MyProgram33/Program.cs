using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyProgram33
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("c:/niit/bellary.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            String fd;
            do
            {
                fd = sr.ReadLine();
                Console.WriteLine(fd);
            } while (fd != null);
            sr.Close();
            fs.Close();
            Console.WriteLine("\n\nFile Data Displayed Successfully");
            Console.ReadKey();
        }
    }
}
