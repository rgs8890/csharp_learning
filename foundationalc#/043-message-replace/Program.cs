string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20); //Removes text between a string
Console.WriteLine(updatedData);

string message = "This--is--ex-amp-le--da-ta";

message = message.Replace("--", " "); //Replaces -- a space
message = message.Replace("-", "");

Console.WriteLine(message);

// Remove() method works like the Substring() method, except that it deletes the specified characters in the string
// Replace() method swaps all instances of a string with a new string
