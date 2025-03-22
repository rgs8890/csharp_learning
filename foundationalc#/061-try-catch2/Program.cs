﻿try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occurred.");
}

static void Process1()
{
    try
    {
        WriteMessage();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception caught in Process1: {ex.Message}");
    }
}

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;

    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);

    checked //This C# keyword is used to explicitly enable overflow checking for arithmetic overflow checking for arithmetic operations and conversions
    {
        int smallNumber = (byte)number1;
    }
}

