using System;

class Program
{
    static void Main()
    {
        string message = "Find what is (inside the parentheses)";

        int openingPosition = message.IndexOf('(');
        int closingPosition = message.IndexOf(')');

        if (openingPosition != -1 && closingPosition != -1 && closingPosition > openingPosition)
        {
            // Extract text inside parentheses
            int length = closingPosition - openingPosition - 1; // Subtract 1 to exclude '('
            Console.WriteLine("Text inside parentheses: " + message.Substring(openingPosition + 1, length));
        }
        else
        {
            Console.WriteLine("No parentheses found or invalid positions.");
        }

        // Example for span tags
        const string openSpan = "<span>";
        const string closeSpan = "</span>";
        string htmlMessage = "This is a <span>test message</span> with tags.";

        int openingPosition2 = htmlMessage.IndexOf(openSpan);
        int closingPosition2 = htmlMessage.IndexOf(closeSpan);

        if (openingPosition2 != -1 && closingPosition2 != -1 && closingPosition2 > openingPosition2)
        {
            openingPosition2 += openSpan.Length; // Move start past <span>
            int length2 = closingPosition2 - openingPosition2; // Compute length
            Console.WriteLine("Text inside span: " + htmlMessage.Substring(openingPosition2, length2));
        }
        else
        {
            Console.WriteLine("No span tags found or invalid positions.");
        }
    }
}
