string[] inputValues = new string[] {"three", "999999999", "0", "2"};

//catch clause can be configured to catch a specific exception type, e.g. DivideByZeroException exception type
//properties of an exception object can be accessed within the catch block; using the Message property to inform the application user of an issue
// specify two or more catch clauses when you need to catch more than one exception type.

foreach (string inputValue in inputValues)
{
    int numValue = 0;
    try
    {
        numValue = int.Parse(inputValue);
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid readResult. Please enter a valid number.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("The number you entered is too large or too small.");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}