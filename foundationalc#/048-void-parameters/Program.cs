// Add parameters to methods
CountTo(5);

void CountTo(int max)
{
    for (int i = 0; i < max; i++)
    {
        Console.Write($"{i}, ");
    }
    Console.WriteLine();
}

int[] schedule = {800, 1200, 1600, 2000};

void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT) 
{
    int diff = 0;
    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
    {
        Console.WriteLine("Invalid GMT");
    }
    else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
    {
        diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    } 
    else 
    {
        diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    }
    for (int i = 0; i < times.Length; i++) 
    {
        int newTime = ((times[i] + diff)) % 2400;
        Console.WriteLine($"{times[i]} -> {newTime}");
    }
}
DisplayAdjustedTimes(schedule, 6, -6);

//Recap
// Information can be passed to methods in the form of parameters
// Parameters are declared in the method signature
// Multiple parameters are seperated by commas
// Methods can accept variable or literal arguments


// Variable Scope
// Variables declared inside of a method are only accessible to that method.
// Variables declared in top-level statements are accessible throughout the program.
// Methods don't have access to variables defined within different methods.
// Methods can call other methods.

string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};

DisplayStudents(students);
DisplayStudents(new string[] {"Robert","Vanya"});

void DisplayStudents(string[] students) 
{
    foreach (string student in students) 
    {
        Console.Write($"{student}, ");
    }
    Console.WriteLine();
}



// Here the variable is declared inside the scope
void PrintCircleArea(int radius)
{
    double pi = 3.14159;
    double area = pi * (radius * radius);
    Console.WriteLine($"Area = {area}");
}
PrintCircleArea(12);
double pi = 3.14159;

// In this case the variable is declared outside of the scope
void PrintCircleAreax(int radius)
{
    double area = pi * (radius * radius);
    Console.WriteLine($"Area = {area}");
}
PrintCircleAreax(12);

// Here we can see the circumference of the circle which is printed
void PrintCircleCircumference(int radius)
{
    double circumference = 2 * pi * radius;
    Console.WriteLine($"Circumference = {circumference}");
}


//double circumference = 2 * pi * radius;
void PrintCircleInfo(int radius) 
{
    Console.WriteLine($"Circle with radius {radius}");
    PrintCircleArea(radius);
    PrintCircleCircumference(radius);
}

PrintCircleInfo(12);
PrintCircleInfo(24);

