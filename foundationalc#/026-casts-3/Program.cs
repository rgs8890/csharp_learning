// string name = "Bob";
// Console.WriteLine(int.Parse(name));

// Parse a string into a given numeric data type
// Stores a value in an out parameter
// Returns a bool to indicate whether the action succeded or not

//string value = "102";
string value = "bad";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}
if (result > 0)
    Console.WriteLine($"Measurement (w/ offset): {50 + result}");



