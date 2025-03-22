string? readResult;
Console.WriteLine("Enter a string: ");
bool validResult = false;

do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validResult = true;
        }
        else 
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validResult == false);



