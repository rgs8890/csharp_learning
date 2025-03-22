// Composite Formatting uses numbered placeholders within a string. At run time, everything inside the braces is resolved to a value that is passed
// in based on their operation.
string first = "Hello";
string second = "World";
string result = string.Format("{0}, {1}", first, second);
Console.WriteLine(result);

Console.WriteLine("{1}, {0}", first, second);
Console.WriteLine("{0}, {0}, {0}", first, second);

string firstx = "Hello";
string secondx = "World";
Console.WriteLine($"{firstx} {secondx}!");
Console.WriteLine($"{secondx} {firstx}!");
Console.WriteLine($"{firstx} {firstx} {firstx}!");

//Formatting Currency
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

// How the user's country/region and language affect string formatting
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");

//Formatting percentages
decimal tax = .36785m;
Console.WriteLine($"Tax Rate: {tax:P2}");