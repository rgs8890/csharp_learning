using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyProgram34
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("c:/niit/MyFile.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            String data;
            Console.Write("Enter Some Text : ");
            data = Console.ReadLine();
            sw.WriteLine(data);
            sw.Flush();
            sw.Close();
            fs.Close();
            Console.WriteLine("\n\nFile Saved Successfully");
            Console.ReadKey();
        }
    }
}
