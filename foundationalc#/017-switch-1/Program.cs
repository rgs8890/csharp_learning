// How to add the branching logic to one that matches one variable or expression against many possible values
// Switch-Case Statement construct to match the variable or expression against other outcomes, using an if-elseif-else construct

using System;

string fruit = "apple";

switch (fruit)
{
    case "apple":
        Console.WriteLine("Apple is a fruit");
        break;
    case "banana":
        Console.WriteLine("Banana is a fruit");
        break;
    case "cherry":
        Console.WriteLine("Orange is a fruit");
        break;
    default:
        Console.WriteLine("Unknown fruit");
        break;
}
// Each switch is defined in a case pattern

int employeeLevel = 200;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
        title = "Junior Associate";
        break;
    case 200:
        title = "Associate";
        break;
    case 300:
        title = "Senior Associate";
        break;
    case 400:
        title = "Manager";
        break;
    case 500:
        title = "Senior Manager";
        break;
    case 600:
        title = "Director";
        break;
    default:
        title = "Unknown";
        break;
}

Console.WriteLine($"{employeeName}, {title}.");

// Switch statement should be used with one value that has many possible matches, each match needing to have a branch in the coding logic
// Single Switch Statement code logic can be matched using one or more labels defined by the case keyword
// An optional default label and switch section can be used when no other case labels matched


