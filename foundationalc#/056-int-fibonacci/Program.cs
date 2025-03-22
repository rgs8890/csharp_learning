Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");    
string response = Console.ReadLine();

bool ShouldPlay(string response)
{   
    response = response.ToLower();
    
    switch(response)
    {
        case "y":
            return true;
        case "n":
            return false;
        default:
            return false;
    }
}

if (ShouldPlay(response)) 
{
    PlayGame();
}

void PlayGame() 
{
    var play = true;

    while (play) 
    {
        var target = random.Next(1, 6);
        var roll = random.Next(1, 7);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");
        string response = Console.ReadLine();

        play = ShouldPlay(response);
    }
}

string WinOrLose(int target, int roll)
{
    string result = "";
    if (target > roll)
    {
        result = "You lose!";
    }
    else if (target < roll)
    {
        result = "You win!";
    }
    else
    {
        result = "Draw";
    }
    return result;
}

// Here is another solution
Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}

bool ShouldPlay() 
{
    string response = Console.ReadLine();
    return response.ToLower().Equals("y");
}

void PlayGame() 
{
    var play = true;

    while (play) {
        var target = GetTarget();
        var roll = RollDice();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

int GetTarget() 
{
    return random.Next(1, 6);
}

int RollDice() 
{
    return random.Next(1, 7);
}

string WinOrLose(int roll, int target) 
{
    if (roll > target) 
    {
        return "You win!";
    }
    return "You lose!";
}