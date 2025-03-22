string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here
Console.WriteLine("Dear " + customerName);
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.");
Console.WriteLine("");
Console.WriteLine($"Currently, you own {currentShares:N} at a return of {currentReturn: P2}.");
Console.WriteLine("");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn: P2}. Given your current volume, your potential profit would be {newProfit: C}");
Console.WriteLine("");
Console.WriteLine("Here's a quick comparison:");
Console.WriteLine("");

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += currentReturn.ToString("P2").PadRight(15);
comparisonMessage += currentProfit.ToString("C0").PadLeft(15);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += newReturn.ToString("P2").PadRight(15);
comparisonMessage += newProfit.ToString("C0").PadLeft(15);

Console.WriteLine(comparisonMessage);

//Alternative Way for String Formatting
string comparisonMessage = "";

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);