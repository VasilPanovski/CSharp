using System;
using System.Globalization;
using System.Threading;

class QuadraticEquation
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());

        while (a == 0)
        {
            Console.WriteLine(@"The value of ""a"" must be different from ""!");
            a = double.Parse(Console.ReadLine()); 
        }
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        double discriminant = b * b - (4 * a * c);
        double x1 = 0;
        double x2 = 0;

        if (discriminant < 0)
        {
            Console.WriteLine("No real roots!");
        }
        else if (discriminant == 0)
        {
            x1 = -b / (2 * a);
            Console.WriteLine("x1 = x2 = {0:F1}", x1);
        }
        else 
        {
            x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("x1 = {0:F1}, x2 = {1:F1}", x2, x1);

        }

    }
}

