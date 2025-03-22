// Iterate through a code block using for statement in C#
// Use a for statement to loop through a code block, with a .NET runtime executing through looping logic, changing the value of the iterator, the condition and control pattern
// foreach allows you to iterate through each block of code until a condition is met
// For statements on the other hand give you more control over the process of iteration

using System;

// for (int i = 10; i >= 0; i--)
// {
//     Console.WriteLine(i);
//     if (i == 7) break;
// }

// for (int i = 0; i < 10; i += 3)
// {
//     Console.WriteLine(i);
// }

// string[] names = { "Alex", "Eddie", "David", "Micheal"};
// for (int = names.Length - 1 ; i >= 0; i--)
// {
//     Console.WriteLine(names[i]);
// }

string[] names = { "Alex", "Eddie", "David", "Micheal"};
for (int i = 0; i < names.Length; i++)
    if (names[i] == "David") names[i] = "Sammy";

foreach (var name in names) Console.WriteLine(name);