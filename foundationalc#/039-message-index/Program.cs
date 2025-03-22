using System;

class Program
{
    static void Main()
    {
        string message = "hello there!";

        int firstH = message.IndexOf('h'); // Get first occurrence of 'h'
        int lastH = message.LastIndexOf('h'); // Get last occurrence of 'h'

        Console.WriteLine($"For the message: '{message}', the first 'h' is at position {firstH} and the last 'h' is at position {lastH}.");

        if (firstH != -1 && lastH != -1 && lastH > firstH) // Ensure valid indexes
        {
            int length = (lastH - firstH) + 1; // Include last 'h' in the substring
            Console.WriteLine("Extracted substring: " + message.Substring(firstH, length));
        }
        else
        {
            Console.WriteLine("Could not extract a valid substring.");
        }
    }
}
