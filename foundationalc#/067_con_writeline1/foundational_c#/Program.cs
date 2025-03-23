using System;

namespace myApp
{
    class Program1
    {
        static void Main(string[] args)
        {
            // Part 1 - Write your first C# code)
            // C# is case-sensitive and compilers can read it differently
            // Console.Write will print a message on the same line, but Console.WriteLine will append a new line after the output.
            Console.WriteLine("Hello World!");
            Console.Write("Hello World");
            Console.Write("You wrote your first lines of code.");


            // Part 2 - Store and Retrieve data using literal and variable values in C#)
            // Variable is container for storing type of value which can change and vary throughout program
            // Variables cannot be C# keyword, cannot contain $ but can _ and #, case-sensitive and camelcase, stored in computer memory temporarily
            string firstName;
            int gameScore;
            decimal particlesPerMillion;
            bool processedCustomer;

            // Must set the value before getting it; can initialise a variable by assigning it to the variable at declaration point, assignment happens from left to write, single equals character is the assignment
            // operator, you can reassign variables here
            firstName = "Bob";
            Console.WriteLine(firstName);
            firstName = "Liem";
            Console.WriteLine(firstName);
            firstName = "Isabella";
            Console.WriteLine(firstName);

            //var keyword allows c# to infer the kind of variable which is being used
            //implicitly typed variables must be initialised
            var message = "Hello World!";
            //message = 10.703m; This will not work!

            //.NET editor to select and DELETE or BACKSPACE key
            string name = "Bob";
            int messages = 3;
            double temperature = 34.4;

            Console.WriteLine($"Hello, {name}! You have {messages} messages in your inbox. The temperature is {temperature} celsius.");
            // Alternative Solution
            Console.Write("Hello, ");
            Console.Write(name);
            Console.Write("! You have ");
            Console.Write(messages);
            Console.Write(" messages in your inbox. The temperature is ");
            Console.Write(temperature);
            Console.Write(" celsius.");

            //NOTE: m/M denoted a decimal data type, where deimal values can include the values after the decimal point has been displayed

            // Part 3 - Perform Basic String Formatting in C#)
            // Character Escape Sequences - An escape character sequence is an instruction to the runtime to insert a special character to affect the output of the string
            Console.WriteLine("Hello\nWorld"); // World is in a new line
            Console.WriteLine("Hello\tWorld"); // Tab between the strings
            Console.WriteLine("Hello \"Hello\"!"); // The \ allows for the quotation marks to be printed within the console.

            // Verbatim String Literal
            Console.WriteLine(@"        c:\source\repos
                        (this is where your code goes)");
            Console.WriteLine(@"c:\invoices");
            // Another unicode escape character
            // A four-character code representing some character in Unicode (UTF-16)
            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

            // Use character escape sequences when needing to insert a special character into a literal string, like a tab \t, new line \n, or a double quotatio mark \"
            // Use an escape character for the backslash \\ when needing to backslash in all the other scenarios
            // Use the @ directive to create a verbatim string literal to keep all whitespace formatting and backslash characters within a string
            // Use the \u plus a four-character code to represent Unicode characters (UTF-16) in a string

            // Combine strings using string concatenation
            string firstName1 = "Bob";
            string message1 = "Hello " + firstName1;
            Console.WriteLine(message);

            // Avoiding intermediate variables
            string firstName2 = "Bob";
            string greeting = "Hello";
            Console.WriteLine(greeting + " " + firstName2 + "!");

            // String Interpolation
            string message3 = greeting + " " + firstName + "!";
            string message4 = $"{greeting} {firstName}";

            // String Interpolation with Multiple Variablkes
            int version = 11;
            string updateText = "Update to Windows";
            Console.WriteLine($"{updateText} {version}!");

            // Use string interpolation with multiple variables and literal strings
            string projectName = "First-Project";
            Console.WriteLine($@"C:\Output\{projectName}\Data");

            // Exercise Solution (Mine):
            string projectNamex= "ACME";

            string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

            Console.WriteLine($@"View English output: 
            c:\Exercise\{projectName}\data.txt");
            Console.WriteLine("\n");
            Console.WriteLine($@"{russianMessage}: 
            c:\Exercise\{projectName}\data.txt");

            // Other Solution: 
            string projectNamey = "ACME";
            string englishLocation = $@"c:\Exercise\{projectNamey}\data.txt";
            Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

            string russianMessagey = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
            string russianLocation = $@"c:\Exercise\{projectNamey}\ru-RU\data.txt";
            Console.WriteLine($"{russianMessagey}:\n\t\t{russianLocation}\n");

            // @ defines when identifies match C# keywords
            // varbatim string literals -> verbatim string ignores escape sequences like \n and allows multi-line strings, making it useful for file_paths and regular expressions

            // Part 4)
            // Mix data types to force implicity type conversions. Attempt a more advanced case of adding numbers and concatenating strings
            string firstNamec = "Bob";
            int widgetsSold = 7;
            Console.WriteLine(firstNamec + " sold " + widgetsSold + 7 + " widgets");

            // Add parantheses to clarify you intention to the compiler. Add parantheses to clarify your intention to the compiler
            string firstNamex = "Bob";
            int widgetsSoldx = 7;
            Console.WriteLine(firstNamex + " sold " + (widgetsSoldx + 7) + " widgets.");

            int firstNumbertx = 12;
            int secondNumbertx = 7;
            Console.WriteLine(firstNumbertx + secondNumbertx);

            // Write code to perform addition, subtraction, multiplication, and division with integers
            int sum = 7 + 5;
            int difference = 7 - 5;
            int product = 7 * 5;
            int quotient = 7 / 5;
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);

            decimal decimalQuotient = 7.0m / 5;
            Console.WriteLine($"Decimal quotient: {decimalQuotient}");
            // Add code to cast results of integer divisions
            int first = 7;
            int second = 5;
            decimal quotientx = (decimal)first / (decimal)second;
            Console.WriteLine(quotient);
            // Code to determine the remainder after integer division
            Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
            Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

            // Order of operations
            int value1 = 3 + 4 * 5;
            int value2 = (3 + 4) * 5;
            Console.WriteLine(value1);
            Console.WriteLine(value2);

            // Use operators like +, -, *, and / to perform basic mathematical operations, division of two int values will result in the truncation
            // PEMDAS (Parantheses, Exponents, Multiplication & Division, Addition & Subtraction


            // Increment and Decrement
            int value = 0;
            value = value + 5;
            value += 5;

            int valuex = 0;
            valuex = valuex + 1;
            valuex++;

            // Different ways of Incrementing and Decrementing
            int valuey = 1;

            valuey = valuey + 1;
            Console.WriteLine("First increment: " + value);

            valuey += 1;
            Console.WriteLine("Second increment: " + value);

            valuey++;
            Console.WriteLine("Third increment: " + value);

            valuey = valuey - 1;
            Console.WriteLine("First decrement: " + value);

            valuey -= 1;
            Console.WriteLine("Second decrement: " + value);

            valuey--;
            Console.WriteLine("Third decrement: " + value);

            // You can also do this
            int valuez = 1;
            value++;
            Console.WriteLine("First: " + value);
            Console.WriteLine($"Second: {value++}");
            Console.WriteLine("Third: " + value);
            Console.WriteLine("Fourth: " + (++value));
            // value++ will increment the value after printing it, but ++value will increment the value

            Console.WriteLine($"Second: {value++}");
            Console.WriteLine("Third: " + value);
            Console.WriteLine("Fourth: " + (++value));
            // We can use compound assignment operators like +=, -=, *=, ++ and -- which will perform mathematical operations like increment or decrement, to assign the result to the original value
            // Incremeent and Decrement operators differently depending on whether the operator is before or after the operand.

            // Fahrenheit Question
            int fahrenheit = 94;
            decimal celsius = (fahrenheit - 32m) * 5m / 9m;
            Console.WriteLine($"The termperature is {celsius} Celsius.");
            // make sure you put m otherwise it will round to 1 decimal place

            Console.WriteLine(5/10);

            //Notes on Quiz
            Console.Write("Windows" + 1 + 1); // Will print Windows 11
            int result = 3 + 1 * 5 / 2; // PEMDAS -> Power, Exponent, Multiplication, Addition, Division

            Console.WriteLine(5 / 10); // 0 (int within the console and it rounds down in c#)
            value += 5; // Addition Assignment Operator
            value++; // Addition ++

        }
    }
}


