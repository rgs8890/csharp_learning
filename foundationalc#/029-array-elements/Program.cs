using System;

string[] pallets = [ "B14", "A11", "B12", "A13"];

// Using Array.Sort()
Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Using Array.Reverse()
Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Using Array.Clear()
// Clear will eliminate all the contents within the specific array, and replace them with the array's default value; which for instance; if we clear an element in a string array
// the cleared value is replaced with null
// However when we clear an elememtn into an int array, the replacement is zero

Console.WriteLine($"Before: {pallets[0]}");
Array.Clear(pallets, 0, 2); // Clears two elements from the 0th element index in the array
Console.WriteLine($"After: {pallets[0]}"); // This will present an empty string

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
// Compiler converts the null value into an emptry string for presentation

// Calling a String Helper Method on a cleared element
if (pallets[0] != null)
    Console.WriteLine($"After: {pallets[0].ToLower()}");

// Resizing the array to add more elements
Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Resizing the array to remove elements
Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// In terms of removing null elements in the array, Array.Resize() method does not more empty elements from an array.

