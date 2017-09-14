using System;
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        Console.Write("Enter time (hh:mm tt): ");
        string input = Console.ReadLine();

        DateTime beerTime = new DateTime();
        bool checkFormat = DateTime.TryParseExact(input, "h:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out beerTime);
        DateTime startTime = DateTime.Parse("1:00 PM");
        DateTime endTime = DateTime.Parse("3:00 AM");

        if (checkFormat)
        {
            if (beerTime >= startTime || beerTime <= endTime)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        else
        {
            Console.WriteLine("invalid time");
        }
    }
}

