// Methods cannot perform operations, but they return a value too; including a return type within a method signature
// Methods can return any data type, or they can return nothing at all
//void PrintMessage(string message);

double total = 0;
double minimumSpend = 30.00;

double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

Console.WriteLine($"Total: ${total}");

double GetDiscountedPrice(int itemIndex)
{
    return items[itemIndex] * (1 - discounts[itemIndex]);
}

bool TotalMeetsMinimum()
{
    return total >= minimumSpend;
}

string FormatDecimal(double input)
{
    return input.ToString().Substring(0, 5);
}

for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountedPrice(i);
}

if (TotalMeetsMinimum())
{
    total -= 5.00;
}

Console.WriteLine($"Total: ${FormatDecimal(total)}");

//Recap
//Methods can return a value by specifying the return data type or void for no return value
//Return keyword can be used with variables, literals and expressions
//Value returned from a method must match the specific return type
//Data returned from methods can be captured and used by the caller of the method