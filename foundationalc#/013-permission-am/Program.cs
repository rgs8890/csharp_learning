string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else if (level <= 55)
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level > 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else if (level <= 20)
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}

// Another way to write the same code
string output = permission.Contains("Admin") ? level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user." : permission.Contains("Manager") ? level > 20 ? "Contact an Admin for access." : "You do not have sufficient privileges." : "You do not have sufficient privileges.";
Console.WriteLine(output);