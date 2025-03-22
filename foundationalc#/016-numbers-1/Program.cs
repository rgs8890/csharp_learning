int[] numbers = {4, 8, 15, 16, 23, 42};
bool found = false;
int total = 0;

foreach (int number in numbers)
{
    total += number;

    if (number == 42)
        found = true;
}

if (found) 
{
    Console.WriteLine("Set contains 42.");
}
else
{
    Console.WriteLine("Set does not contain 42.");
}

Console.WriteLine($"Total: {total}");