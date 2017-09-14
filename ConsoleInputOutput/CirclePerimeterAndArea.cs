using System;
using System.Globalization;
using System.Threading;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        new CultureInfo("en-US");

        Console.Write("r = ");
        double radius = double.Parse(Console.ReadLine());

        double circlePerimeter = 2 * radius * Math.PI;
        double circleArea = Math.PI * radius * radius;

        Console.WriteLine("The perimeter of the circle = {0:F2}", circlePerimeter);
        Console.WriteLine("The area of the cercle = {0:F2}", circleArea);

    }
}

