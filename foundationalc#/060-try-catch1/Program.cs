try
{
    WriteMessage();
}
catch
{
    Console.WriteLine("An exception has been caught.");
}
Console.WriteLine("Exit program");

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 0;
    int number2 = 0;

    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
}