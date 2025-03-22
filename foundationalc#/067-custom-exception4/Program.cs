string[][] userEnteredValues = new string[][]
{
    new string[] { "1", "2", "3" },
    new string[] { "1", "two", "3" },
    new string[] { "0", "1", "2" }
};

try
{
    Workflow1(userEnteredValues);
    Console.WriteLine("'Workflow1' completed successfully.");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("An error occurred during 'Workflow'.");
    Console.WriteLine(ex.Message);
}

static void Workflow1(string[][] userEnteredValues)
{
    foreach (string[] userEntries in userEnteredValues)
    {
        try
        {
            Process1(userEntries);
            Console.WriteLine("'Process1' completed successfully.\n");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("'Process1' encountered an issue, process aborted.");
            Console.WriteLine(ex.Message + "\n");
        }
    }
}

static void Process1(string[] userEntries)
{
    foreach (string userValue in userEntries)
    {
        bool integerFormat = int.TryParse(userValue, out int valueEntered);

        if (integerFormat)
        {
            if (valueEntered != 0)
            {
                // Perform calculation just to demonstrate logic
                checked
                {
                    int calculatedValue = 4 / valueEntered;
                }
            }
            else
            {
                throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
            }
        }
        else
        {
            throw new FormatException("Invalid data. User input values must be valid integers.");
        }
    }
}
