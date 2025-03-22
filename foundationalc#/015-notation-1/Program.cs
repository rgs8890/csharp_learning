bool flag = true;
if (flag)
{
    Console.WriteLine(flag);
}

// Change this this into single line
bool flag2 = true;
if (flag2) Console.WriteLine(flag2);

// This is not good practice, it is harder to read
string name "Steve";
if (name == "bob") Console.WriteLine("Found Bob");
else if (name == "steve") Console.WriteLine("Found Steve");
else if (name == "joe") Console.WriteLine("Found Joe");
else Console.WriteLine("Name not found");

// This is better practice (Microsoft allows you to remove the curly braces, if you have an if...else if....else statement)
string name2 = "Steve";
if (name2 == "bob")
    Console.WriteLine("Found Bob");
else if (name2 == "steve")
    Console.WriteLine("Found Steve");
else if (name2 == "joe")
    Console.WriteLine("Found Joe");
else
    Console.WriteLine("Name not found");