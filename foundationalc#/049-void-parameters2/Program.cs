// Use value and reference type parameters
// Parameters passed by value and passed by reference

int a = 3;
int b = 4;
int c = 0;

Multiply(a, b, c);
Console.WriteLine($"global statement: {a} x {b} x {c}");

void Multiply(int a, int b, int c)
{
    c = a * b;
    Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
}

// Test Pass by Reference
int[] array = {1, 2, 3, 4, 5};
PrintArray(array);
Clear(array);
PrintArray(array);

void PrintArray(int[] array)
{
    foreach (int a in array)
    {
        Console.Write($"{a} ");
    }
    Console.WriteLine();
}

void Clear(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = 0;
    }
}

// Testing with Strings
string status = "Healthy";

Console.WriteLine($"Start {status}");
SetHealth(false);
Console.WriteLine($"End {status}");

void SetHealth(bool isHealthy)
{
    status = (isHealthy? "Healthy" : "Unhealthy");
    Console.WriteLine($"Middle: {status}");
}

// Recap
// Variables can be categorized as value types and reference types.
// Value types directly contain values, and reference types store the address of the value.
// Methods using value type arguments create their own copy of the values.
// Methods that perform changes on an array parameter affect the original input array.
// String is an immutable reference type.
// Methods that perform changes on a string parameter don't affect the original string.