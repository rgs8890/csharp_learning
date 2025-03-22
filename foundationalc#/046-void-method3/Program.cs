string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
string[] address;
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

foreach (string ipv4 in ipv4Input)
{
    address = ipv4.Split(".", StringSplitOptions.RemoveEmptyEntries);

    ValidLength();
    ValidZeroes();
    ValidRange();

    if (validLength && validZeroes && validRange)
    {
        Console.WriteLine($"{ipv4} is a valid IPv4 address.");
    }
    else
    {
        Console.WriteLine($"{ipv4} is an invalid IPv4 address.");
    }
}

void ValidLength()
{
    validLength = address.Length == 4;
};

void ValidZeroes()
{
    foreach (string number in address)
    {
        if (number.Length > 1 && number.StartsWith("0"))
        {
            validZeroes = false;
        }
    }

    validZeroes = true;
};

void ValidRange()
{
    foreach (string number in address)
    {
        int value = int.Parse(number);
        if (value < 0 || value > 255)
        {
            validRange = false;
            return;
        }
    }
    validRange = true;
}

