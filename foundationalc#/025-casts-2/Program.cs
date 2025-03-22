// int first = 2;
// string second = "4";

// int result = first + second;
// Console.WriteLine(result);

int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt; //Since int can easily fit inside
Console.WriteLine($"decimal:  {myDecimal}");

// Perform a cast
decimal myDecimalx = 3.14m;
Console.WriteLine($"decimal: {myDecimalx}");

int myIntx = (int)myDecimalx;
Console.WriteLine($"int: {myIntx}");

// Determine if your conversion is a widening or narrowing conversion
// Narrowing Conversion : Attempting to convert a value from a data type which can hold more information to a data type which can hold less information
// Precision: Number of values after the decimal point
decimal myDecimaly = 1.23456789m;
float myFloaty = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimaly}");
Console.WriteLine($"Float  : {myFloaty}");

// Performing Data Conversions
// Converting Integer to String
int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);

// Converting String to Integer
string firstx = "5";
string secondx = "7";
int sum = int.Parse(firstx) + int.Parse(secondx);
Console.WriteLine(sum);

// Convert a string to an int using the "Convert" class
string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);

// Compare casting and converting a decimal to an int
int valuez = (int)1.5m;
Console.WriteLine(valuez);

int valuezy = Convert.ToInt32(1.5m);
Console.WriteLine(valuezy);

