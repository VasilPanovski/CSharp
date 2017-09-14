using System;
using System.Globalization;
using System.Threading;

class FourFactors
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        new CultureInfo("en-US");

        uint fieldGoals = uint.Parse(Console.ReadLine());
        uint fieldGoalsAttempts = uint.Parse(Console.ReadLine());
        uint pointFieldGoals = uint.Parse(Console.ReadLine());
        uint turnovers = uint.Parse(Console.ReadLine());
        uint offensiveRebounds = uint.Parse(Console.ReadLine());
        uint opponentOffenseRebounds = uint.Parse(Console.ReadLine());
        uint freeThrows = uint.Parse(Console.ReadLine());
        uint freeThrowAttempt = uint.Parse(Console.ReadLine());

        decimal shootingFactor = (decimal)(fieldGoals + 0.5 * pointFieldGoals) / fieldGoalsAttempts;
        decimal turnoverFactor = (decimal)(turnovers / (fieldGoalsAttempts + 0.44 * freeThrowAttempt + turnovers));
        decimal reboundingFactor = (decimal)offensiveRebounds / (offensiveRebounds + opponentOffenseRebounds);
        decimal freeThrowFactor = (decimal)freeThrows / fieldGoalsAttempts;

        Console.WriteLine("eFG% -> {0:F3}", shootingFactor);
        Console.WriteLine("TOV% -> {0:F3}", turnoverFactor);
        Console.WriteLine("ORB% -> {0:F3}", reboundingFactor);
        Console.WriteLine("FT% -> {0:F3}", freeThrowFactor);
    }
}

