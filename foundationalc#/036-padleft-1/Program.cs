string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!",first, second);
Console.WriteLine(result);

// Padding
string input = "Pad this";

Console.WriteLine(input.PadLeft(12, '-'));  // Output: "----Pad this"
Console.WriteLine(input.PadRight(12, '-')); // Output: "Pad this----"

// Uncommented the original PadLeft() example
Console.WriteLine(input.PadLeft(12));
// PadLeft and PadRight are overloaded methods and can call more than one parameter, or just one parameter

string paymentId = "769C";
string payeename = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";
var formattedLine = paymentId.PadRight(6);
formattedLine += payeename.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);