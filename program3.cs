int Superman = 10;
int Batman = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    Batman -= roll;
    Console.WriteLine($"Batman was damaged and lost {roll} health and now has {Batman} health.");    if (Batman <= 0) continue;

    roll = dice.Next(1, 11);
    Superman -= roll;
    Console.WriteLine($"Superman was damaged and lost {roll} health and now has {Superman} health.");

} while (Superman > 0 && Batman > 0);

Console.WriteLine(Superman > Batman ? "Superman wins!" : "Batman wins!");