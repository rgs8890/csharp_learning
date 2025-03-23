This folder will contain all my learning from the foundational C# Certificate with an overview of the concepts I have learnt. I would like to extend my thanks to Sacha Barber and Francois Ludovic from TP ICAP, as learning from them and watching them code made me want to pursue learning C# more.

## C# Learning Projects (60+)

| Project No | Name               | Main Programming Concepts                                                                                 |  
|------------|--------------------|-----------------------------------------------------------------------------------------------------------|
| 001        | hello_world        | Console.WriteLine(), Random dice = new Random(), int roll = dice.Next();                                  |
| 002        | sqr_root           | Math.Max(), Math.Sqrt()                                                                                   |
| 003        | roll_dice          | dice.Next(), roll1 == roll2, int total = roll1 + roll2 + roll3                                            |
| 004        | roll_dice2         | total >= 16, roll1 + roll2 + roll3                                                                        |
| 005        | day_expiration     | discountPercentage, daysUntilExpiration, Random random = new Random();                                    |
| 006        | fraudulent_o       | string[] fraudulentOrderIDs, static void Main(string[] args)                                              |
| 007        | foreach_1          | int[] inventory = { 200, ... }, foreach(int items in inventory), sum+=,bin++                              |
| 008        | array_ABCG         | string[] myArray, foreach (string orderID in myArray), orderID.StartsWith()                               |
| 009        | random_orderid     | for (int i = 0; i < orderIDs.Length, i++), Convert.ToChar().ToString()                                    |
| 010        | string_char_c      | char[] charMessage, str.ToCharArray(), Array.Reverse(), $"o appears {x} time"                             |
| 011        | comparison_op      | Trim(), ToLower(), saleAmount > 1000 ? 100 : 50, pangram.Contains("fox")                                  |
| 012        | tails_heads        | Random rnd = new Random(), coin.Next(0, 2), rnd.Next(0,2)                                                 |
| 013        | permission_am      | permission.Contains("Manager") ? level > 55 Welcome : Not Welcome;                                        |
| 014        | bool_flag1         | bool flag = true, int value = 5, if (true)                                                                |
| 015        | notation_1         | bool flag = true, if (flag), if (!flag) if(name=="Bob")Console.WriteLine("Bob")                           |
| 016        | numbers_1          | int[] numbers = {4, 8, 15, 16, 23, 42}, bool found = false, total += number                               |
| 017        | switch_1           | switch(employee) { case 100: title = "Junior" break;                                                      |
| 018        | switch_2           | switch(product[0])                                                                                        |
| 019        | notation_2         | for(int i = 0; i < names.Length; i++) if (names[i] == "David" names[i]                                    |
| 020        | integer_fizz       | for(int i = 0; i < 100; i++) if (i % 3 == 0 && i % 5 == 0)                                                |
| 021        | do_while1          | do { current = Random.Next(1, 11); if (current >= 8) continue;                                            |
| 022        | do_while2          | do {int roll = random.Next(1, 11); monster -= roll;                                                       |
| 023        | do_while3          | do {readResult = Console.ReadLine(), readResult != null                                                   |
| 024        | casts_1            | int[] ref_A, ref_A[0], Console.WriteLine()                                                                |
| 025        | casts_2            | int myInt, decimal myDecimal = myInt                                                                      |
| 026        | casts_3            | string value = "bad", int result = 0, int.TryParse(value, out result)                                     |
| 027        | casts_4            | float_number = float.Parse(element), element.Any(char.IsDigit), system.linq                               |
| 028        | casts_5            | int result1 = Convert.ToInt(32), decimal result2 = value2/ (decimal)value3                                |
| 029        | array_elements     | Array.Sort(pallets), Array.Reverse(pallets), Array.Clear(), Array.Resize()                                |
| 030        | string_method1     | string result2 = string.Join(",", valueArray), string[] items = result.Split(,)                           |
| 031        | string_method2     | Array.Reverse(), char[] valueArray = pangram.ToCharArray(), string[]nm =                                  |
| 032        | string_method3     | Array.Sort(orderIds), string[] orderIds = orderStream.Split(',')                                          |
| 033        | format_currency    | string first = "Hello", decimal price = 123.456m                                                          |
| 034        | format_currency2   | decimal price = 67.55m, string yourDiscount = String.Format("You save {0:C2}")                            |
| 035        | format_currency3   | decimal productShares = 23.4568m, decimal taxPercentage = .15825m                                         |
| 036        | padleft_1          | string result = string.Format("{0},{1}!",first,second),input.PadLeft(12, '-')                             |
| 037        | format_currency4   | string customerName = "Ms. Barros", comparisonMessage += currentReturn.ToString()                         |
| 038        | message_span       | int openingPosition = message.IndexOf('('), const string openSpan = "<span>";                             |
| 039        | message_index      | int firstH = message.IndexOf('h'), int lastH = message.LastIndexOf('h')                                   |
| 040        | message_substring  | openingPosition += 1, message.IndexOf('('), message.Substring(openingClosing, length)                     |
| 041        | message_indexofany | int openingPosition = message2.IndexOfAny(openSymbols)                                                    |
| 042        | message_openingP   | int openingPosition, string currentSymbol, switch (currentSymbol), message.IndexOf()                      |
| 043        | message_replace    | string updatedData = data.Remove(5, 20), message.Replace("--", " ")                                       |
| 044        | void method1       | Random random = new Random(), random.Next(1, 100), void DisplayRandomNumbers()                            |
| 045        | void method2       | Math.Abs(newGMT), Convert.ToInt32(Console.ReadLine()), val.ToString(), time.Insert()                      |
| 046        | void_method3       | foreach (string ipv4 in ipv4Input), ipv4.Split(".", StringSplitOptions.RemoveEmptyEntries)                |    
| 047        | void_method4       | string[] text = {}, void tellFortune(), string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral)|
| 048        | void_parameters    | void CountTo(int max), int[] schedule, void DisplayAdjustedTimes(int[] times), void PrintCircleArea()     |
| 049        | void_parameters2   | void PrintArray(int[] array)                                                                              |
| 050        | double_array1      | string[,] corporate                                                                                       |
| 051        | double_array2      | double total = 0, double minimumSpend = 30.00                                                             |
| 052        | int_usdtovnd       | int vnd = UsdToVnd(usd), for (int i = word.Length - 1; i >= 0; i--), string[] words = sentence.Split(" ") |
| 053        | is_palindrome      | bool IsPalindrome(string word), while (start > end) if (word[start] != word[end]), start++, end--         |
| 054        | double_array       | static int[,] TwoCoins(int[] coins, int target), int[,] result                                            |
| 055        | method_1           | Random random = new Random(), bool ShouldPlay(string response), void PlayGame()                           |
| 056        | int_fibonacci      | static int Fibonacci(int n)                                                                               |
| 057        | bool_pausecode     | string[] names = new string[], foreach (string name in names), bool pauseCode                             |
| 058        | static_method1     | int productCount = 2000, string[,] products = new string[productCount, 2]                                 |
| 059        | try_catch          | try { WriteMessage() } catch { Console.WriteLine("An Exception has been caught")                          |
| 060        | try_catch1         | try { Process1() } catch { Console.WriteLine("An exception has occurred").                                |
| 061        | try_catch2         | string[] inputValues = new string[] {"three", "999999999", "0", "2"}  try, catch, catch, finally          |
| 062        | exception_1        | checked try { int num1 = int.MaxValue; int num2 = int.MaxValue } catch (OverFlowException ex)             |
| 063        | exception_2        | foreach(string[] userEntries in userEnteredValues) try, catch (Exception ex) if (ex.StackTrace).Contains  |
| 064        | custom_exception1  | DivideByZeroException unexpectedDivideByZeroException = new DivideByZeroException("DivideByZeroException")|
| 065        | custom_exception2  | try { Console.Write("Enter the lower bound:");, catch (ArgumentOutOfRangeException ex) (FormatException)  |
| 066        | custom_exception3  | try { WorkFlow1(userEnteredValues) catch (DivideByZeroException ex), try{} catch(FormatException)         |
| 067        | con_writeline1     | Console.WriteLine(), Console.Write(), value++, value -=, int, decimal, string, char, celsius = 5m         |
| 068        | if_statement1      | if (total > 14) {Console.WriteLine}, if (message.Contains("fox")){Console.WriteLine("What does fox say")} |
| 069        | variables_1        | sophiaSum = sophia1 + sophia2, sophiaScore = (decimal)sophiaSum / currentAssignments                      |
| 070        | variables_2        | int courseCredit = 3, totalCreditHours += courseCredit1, Console.WriteLine($"{course1Name}\t\t")          |

