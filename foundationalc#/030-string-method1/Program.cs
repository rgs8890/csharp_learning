// Use the ToCharArray() to reverse a string
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result);

// Reverse, then combine the char array into a new string
string result2 = string.Join(",", valueArray);
Console.WriteLine(result2);

// Split(), comma-separated-value string into an array of strings
string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}

