int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subTotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
//3 Decimal places for the number specifider
Console.WriteLine($"     Shares: {productShares:N3} Product");
//Currency added
Console.WriteLine($"     Sub Total: {subTotal:C}");
// Percentage decimals specifier
Console.WriteLine($"     Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Billed: {total:C}");