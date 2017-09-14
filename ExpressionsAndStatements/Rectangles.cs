using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        new CultureInfo("en-US");

        double area = 0;
        double perimeter = 0;

        Console.Write("width: ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("height: ");
        double height = double.Parse(Console.ReadLine());

        area = width * height;
        perimeter = 2 * (width + height);

        Console.WriteLine("Area = {0}, Perimeter = {1}", area, perimeter);

    }
}

