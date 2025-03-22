using System;
using System.Linq;

string[] values = { "12.3", "45", "ABC", "11", "DEF" };
float total = 0;
string message = "";

for (int i = 0; i <= values.Length - 1; i++)
{
    string element = values[i];
    if (element.Any(char.IsDigit))
    {
        float number = float.Parse(element);
        total += number;
    }
    if (element.Any(char.IsLetter))
    {
        message += element + "";
    }
}
Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");

// Another Solution
string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = "";

foreach (var value in values)
{
    decimal number; // stores the TryParse "out" value
    if (decimal.TryParse(value, out number))
    {
        total += number;
    } else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");