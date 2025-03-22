decimal tax = .36785m;
Console.WriteLine($"Tax Rate: {tax:P2}");

// Combining formatting approaches
decimal price = 67.55m;
decimal salePrice = 59.99m;
string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

Console.WriteLine(yourDiscount);

//tax:: P1 rounds a percentage to a single decimal place
//curreny:: C2 rounds the decimal to two decimal places

