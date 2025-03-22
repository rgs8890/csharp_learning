string pangram = "The quick brown fox jumps over the lazy dog";
char[] valueArray = pangram.ToCharArray(); // Converts a string to a series of characters within an array
Array.Reverse(valueArray); //Reverses the characters in an array
string result = new string(valueArray); 
Console.WriteLine(result);

string[] items = result.Split(' ');
string reversedSentence = string.Join(" ", items.Reverse());
Console.WriteLine(reversedSentence);

string pangram2 = "The quick brown fox jumps over the lazy dog";


// Alternate Solution
// Step 1
string[] message = pangram2.Split(' ');

//Step 2
string[] newMessage = new string[message.Length];

// Step 3
for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);    
}
string result2 = string.Join(" ", newMessage);
Console.WriteLine(result2);
