static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
{
    if (upperBound < lowerBound)
    {
        throw new ArgumentOutOfRangeException(nameof(upperBound), "Upper bound must be greater than or equal to lower bound.");
    }

    int sum = 0;
    int count = 0;

    for (int i = lowerBound; i <= upperBound; i++)
    {
        if (i % 2 == 0)
        {
            sum += i;
            count++;
        }
    }

    if (count == 0)
    {
        throw new InvalidOperationException("There are no even numbers in the specified range.");
    }

    return (decimal)sum / count;
}

bool exit = false;

while (!exit)
{
    try
    {
        Console.Write("Enter the lower bound: ");
        int lowerBound = int.Parse(Console.ReadLine());

        Console.Write("Enter the upper bound: ");
        int upperBound = int.Parse(Console.ReadLine());

        decimal averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

        Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");
        exit = true;
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine("⚠️ " + ex.Message);
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine("⚠️ " + ex.Message);
    }
    catch (FormatException)
    {
        Console.WriteLine("⚠️ Please enter valid integer values.");
    }

    Console.Write("Try again? (yes/no): ");
    string response = Console.ReadLine().Trim().ToLower();
    exit = response == "no" || response == "n";
}
