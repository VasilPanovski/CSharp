using System;
using System.Globalization;
using System.Threading;

class GravitationOntheMoon
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        new CultureInfo("en-US");

        double weightOnMoon = 1;

        Console.Write("Insert weight of the man: ");
        double weightOnEarth = double.Parse(Console.ReadLine());

        weightOnMoon = weightOnEarth * 17 / 100;

        Console.WriteLine("The weight of that man on the moon is: {0}", weightOnMoon);
    }
}

