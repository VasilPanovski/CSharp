using System;
using System.Globalization;
using System.Threading;

class PointInACircle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        new CultureInfo("en-US");

        double radius = 2;
        bool isInside = false;

        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());

        if (x*x + y*y <= radius * radius)
        {
            isInside = true;
        }
        else
        {
            isInside = false;
        }
        Console.WriteLine("The piont ({0},{1}) is inside the circle -> {2}", x, y, isInside);
    }
}

