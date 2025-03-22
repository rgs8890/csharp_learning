int heropoints = 10;
int monsterpoints = 10;

Random random = new Random();
int attack = random.Next(1, 11);

int monsterturn = 0;
int heroturn = 0;

do 
{
    attack = random.Next(1, 11);

    if (monsterturn == heroturn && heropoints > 0)
    {
        Console.WriteLine("Hero attacks first.");
        monsterpoints -= attack;
        heroturn++;
        Console.WriteLine($"Monster was damaged and lost {attack} points and now has {monsterpoints} left.");
    }
    else if (monsterturn < heroturn && monsterpoints > 0)
    {
        Console.WriteLine("Monster attacks.");
        heropoints -= attack;
        monsterturn++;
        Console.WriteLine($"Hero was damaged and lost {attack} points and now has {heropoints} left.");
    }

    if (monsterpoints <= 0)
    {
        Console.WriteLine("Hero Wins!");
        break;
    }
    else if (heropoints <= 0)
    {
        Console.WriteLine("Monster Wins!");
        break;
    }

} while (monsterpoints > 0 && heropoints > 0);

// Simplified Logic with ternary operators, continue statements, and also no {} for some blocks
do 
{
    int roll = random.Next(1, 11);
    monster-=roll;
    Console.WriteLine($"Monster was damaged and lost {roll} points and now has {monsterpoints} left.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero-=roll;
    Console.WriteLine($"Hero was damaged and lost {roll} points and now has {hero} left.");

}   while (monster > 0 && hero > 0);
Console.WriteLine(hero > monsterpoints ? "Hero Wins!" : "Monster Wins!");