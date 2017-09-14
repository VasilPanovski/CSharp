using System;
using System.Globalization;
using System.Threading;

class PointInsideCircleAndOutsideRectangle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        new CultureInfo("en-US");

        double radius = 1.5;

        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());

        bool pointInTheCircle = Math.Pow(x-1, 2) + Math.Pow(x-1, 2) <= radius * radius;

        Console.Write("The point is inside the circle and outside the rectangle -> ");
        if (pointInTheCircle && (x > -0.5 && x <= 2.5) && (y <= 2.5 && y > 1))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

