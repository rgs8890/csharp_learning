// Control Variable Scope and Logic using Code Blocks in C#
// if-elseif-else statement selection statement structures
// foreach iteration statement
using System;

bool flag = true;
int value = 5;

if (flag)
{
    Console.WriteLine($"Inside the code block: {value}");
}
value = 10;
Console.WriteLine($"Outside the code block: {value}");

int value2;

if (true)
{
    value2 = 10;
    Console.WriteLine($"Inside the code block: {value2}");
}
Console.WriteLine($"Outside the code block: {value2}");
