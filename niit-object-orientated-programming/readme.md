This is my repo for all the projects done within the NIIT C# Object Orientated Programming Course. When I was in India, Ballari, I was working on this course, and the instructor used a .NET framework of 4.8 to build these introductory projects for the C# Object Orientated Programming Course.

## C# Learning Projects (50+)
  
| Project No | Name               | Programming Concepts Covered                                                                                                                    |  
|------------|--------------------|--------------------------------------------------------------------------------------------------------------------------------------------- ---|
| 001        | con_writeline1     | Console.WriteLine("Hello World"), Console.ReadKey()                                                                                             |
| 002        | form_1             | Creating a form. Application.EnableVisualStyles(), Application.SetCompatibleTextRenderingDefault(false), Application.Run(new Form1())           |
| 003        | enter_number       | Console.Write(), Convert.ToInt32(Console.ReadLine()), z = x + y, Console.WriteLine(Addition of {0}, x)                                          |
| 004        | radius_circle      | double a, r, pi = 3.142, r = Convert.ToDouble(Console.ReadLine()), Console.ReadKey(), a = pi * r * r                                            |
| 005        | enter_number1      | int x; Console.Write("Enter a number: "), if(x > 0) {Console.WriteLine("Number is +ve")}, Console.ReadKey()                                     |
| 006        | enter_number2      | int x; Console.Write("Enter a number: "), x = Convert.ToInt32(Console.ReadLine()), if (x % 2 == 0) {Console.WriteLine("Number even")            |
| 007        | convert_int32      | int x, y; Console.Write("Enter a number for x:"), y = Convert.ToInt32(Console.ReadLine()), Console.ReadKey()                                    |
| 008        | switch_1           | wd = ConvertToInt32(Console.ReadLine()), switch(wd) { case 1: Console.WriteLine("Mon") break; Console.ReadKey()                                 |
| 009        | for_loop_1         | for (int i = 1; i <= 15; i++), Console.WriteLine("Serial No : " + i), Console.ReadKey()                                                         |
| 010        | do_while_loop1     | do { Console.Write("Enter a number (0 to stop) : " sum = sum + n;} while (n != 0); Console.ReadKey()                                            |
| 011        | do_while_loop2     | String wish; double x, y, z; do {Console.Write("Enter a number: "); x = Convert.ToDouble(), wish = Console.ReadKey(), wish.Equals("y")          |
| 012        | for_loop2          | int n, rev = 0, m; Console.Write("Enter a number: "), n = Convert.ToInt32(Console.ReadLine())                                                   |
| 013        | for_loop3          | for (int i = 0; i <= 9; i++), Console.Write("Enter a Number"), x[i] = Convert.ToInt32(Console.ReadLine())                                       |      
| 014        | for_loop4          | int[] x = new int[10], int i, j, temp;, for (i = 0; i < 10; i++) Console.Write("Enter a number"), x[i] = Convert.ToInt32(Console.ReadLine())    |
| 015        | double_array1      | int[,] x = new int[3,3], int i, j;, for (i = 0; i < 3; i++) for (j = 0; j < 3; j++)                                                             |
| 016        | double_array2      | static void Main(string[] args) int[,] x = new int[3,3], int[,]y = new int[3, 3], for (i = 0; i < 3; ++) for (j=0; j < 3; j++)                  |
| 017        | string_1           | string name1, name2, Console.Write("Enter your first number :") Console.WriteLine("Length of Name :" + name1.Length)                            |
| 018        | static_method1     | static int add(int a, int b) {int c; c = a + b return c;)                                                                                       |
| 019        | con_writeline2     | int rollno, age, grade, sub1, sub2 Console.Write("Enter RollNo") rollno = Convert.ToInt32(Console.ReadLine()), total = sub1 + sub2 + sub3       |
| 020        | void_method_1      | Console.Write("Enter a rollno:"), rollno = Convert.ToInt32(Console.ReadLine()), name = Console.ReadLine(); public void CalcResult()             |
| 021        | array_1            | for (int i = 0; i<5; i++) { s[i] = new Student();, s[i] = inputData(), s[i].calcResult(), Console.Clear(), Console.ReadKey()                    |
| 022        | overloading_method | class Student int rollno, age, grade, sub1, sub2, sub3, String name, gender, result, public Student(), public Student(int r, String n)          |
| 023        | overloading_method2| double i, j, k; Calculations c = new Calculations(), Console.Write("Enter a number":)                                                           |
| 024        | overloading_method3| double i, j, k; Calculations c = new Calculations(); public void add(double x, double y), public void add(int x, int y)                         |
| 025        | overloading_method4| Operator Overloading. public void display(), public Box add(Box x), public static Box operator + (Box x, Box y)                                 |
| 026        | inheritance_1      | class ColorBox: Box3D, String color, public void getInfo(), public void showInfo()                                                              |
| 027        | inheritance_2      | class Student: Person int rollno, std marks, public Student(int rollno, String name, String gender) : base(name, gender, age)                   |
| 028        | inheritance_3      | class Box3D; Box, public void accept(), public void display(),                                                                                  |
| 029        | abstract_class     | abstract class Person, protected String name, gender, protected int age, public void accept(), public abstract void display(), override         |
| 030        | try_catch          | try{} catch(DivideByZeroException ex) catch (FormatException as ex), finally Console.WriteLine(Console.WriteLine("Happy Ending"))               |
| 031        | custom_exception   | try { Person p = new Person(), p.accept(), p.display(), catch (InvalidAgeException ex) {Console.WriteLine("Please Do Check The Age Again.");    |
| 032        | file_steaming      | static void Main(string[] args) {FileStream fs = new FileStream("path", FileMode.Open, FileAccess.Read), StreamReader sr = new StreamReader(fs);|
| 033        | file_streaming2    | FileStream fs = new FileStream("path", FileMode.Append, FileAccess.Write), StreamWriter sw, String data, sw.WriteLine("Enter Some text: ")      |
| 034        | threading          | Thread th = Thread.CurrentThread, Console.WriteLine("Thread Name: ", th.Name); th.Name = "MyMainThread", Console.WriteLine("Thread Name: ")     |
| 035        | threading2         | BasicThread bt = new BasicThread(), ThreadStart ts1 = new ThreadStart(bt.fun1), Theard t1 = new Thread(ts1), t1.Start(), t2.Start()             |
| 036        | arrayList1         | ArrayList al = new ArrayList(), al.Add(10), al.Add(40), for (int i = 0; i < al.Count; i++) {Console.WriteLine("Item : " + al[i]), al3.Sort()    |
| 037        | arrayList2         | ArrayList al = new ArrayList(), al.Add("A"), foreach(String a in al), al.Remove("F"), al.RemoveAt(4), al.RemoveRange(0, 3)                      |
| 038        | list1              | List<int> ls = new List<int>(), ls.Add(10), foreach (int n in ls)                                                                               |
| 039        | hashtable1         | Hashtable ht = new HashTable(), ht.Add(1001, "Raj"), ht.Add(1002, "Uma"), ICollection k = ht.Keys' foreach (var n in k)                         |
| 040        | linkedlist         | LinkedList<String> ll = new LinkedList<string>();, ll.AddLast("India"), ll.AddLast("China"), ll.Remove("Nepal"), ll.AddBefore(ll.Find("Spain")) |
| 041        | stack1             | Stack s = new Stack();, s.Push("India"), s.Push("China"), s.Pop()                                                                               |
| 042        | queue1             | Queue q = new Queue(), q.Enqueue("Apple"), q.Enqueue("Banana"), q.Dequeue()                                                                     |
| 043        | delegates1         | public delegate void addnum(int a, int b), static void Main(string[] args) { MyCalculations m = new MyCalculations();}                          |
| 044        | delegates2         | public delegate void rectDelegate(double height, double width), Rectangle r = new Rectangle(), rectDelegate rd = r.area;                        |
| 045        | gui_program1       | static class Program, Form1                                                                                                                     |
| 046        | gui_program2       | Console.Write(), Convert.ToInt32(Console.ReadLine()), z = x + y, Console.WriteLine(Addition of {0}, x)                                          |
| 047        | gui_program3       | RedForm(), BlueForm(), GreenForm(), Form1()                                                                                                     |
| 048        | gui_program_dataset|                                                                                                                                                 |  
| 049        | gui_program_data1  |                                                                                                                                                 |
| 050        | gui_program_data2  |                                                                                                                                                 |
| 051        | gui_program_data3  |                                                                                                                                                 |
