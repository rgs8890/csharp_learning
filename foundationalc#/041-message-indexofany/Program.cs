string message = "Hello, world!";
char[] charsToFind = { 'a', 'e', 'i'};

int index = message.IndexOfAny(charsToFind);

Console.WriteLine($"Found '{message[index]} in '{message}' at index: {index}.");

string message2 = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message2}");

char[] openSymbols = {'[', '{', '('};
int startPosition = 5;
int openingPosition = message2.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message2.Substring(openingPosition)}");

openingPosition = message2.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition {startPosition}: {message2.Substring(openingPosition)}");

