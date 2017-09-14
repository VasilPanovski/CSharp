using System;
using System.Globalization;
using System.Threading;

class TrapezoidsArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        new CultureInfo("en-US");

        double area = 0;

        Console.Write("a = ");
        double sideA = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        double sideB = double.Parse(Console.ReadLine());

        Console.Write("h = ");
        double height = double.Parse(Console.ReadLine());

        area = ((sideA + sideB) * height) / 2;
        Console.WriteLine("Area = {0}", area);
    }
}

