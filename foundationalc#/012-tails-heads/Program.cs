using System;

Random rnd = new Random();

int round = rnd.Next(0, 2);

if (round == 1)
{
    Console.WriteLine("Heads");
}
else
{
    Console.WriteLine("Tails");
}

Random coin = new Random();
Console.WriteLine(coin.Next(0, 2) == 1 ? "Heads" : "Tails");
