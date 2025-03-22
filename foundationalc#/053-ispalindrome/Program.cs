//String Methods
string input = "snake";

string ReverseWord(string word)
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--)
    {
        result += word[i];
    }
    return result;
}

Console.WriteLine(input);
Console.WriteLine(ReverseWord(input));

string input2 = "there are snakes at the zoo";

string ReverseSentence(string sentence)
{
    string result = "";
    string[] words = sentence.Split(" ");
    foreach (string word in words)
    {
        result += ReverseWord(word) + " ";
    }
    return result.Trim();
}

Console.WriteLine(ReverseSentence(input2));
