using System;
using System.Globalization;
using System.Threading;

class NumbersFrom1ToN
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        new CultureInfo("en-US");

        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        double sum = 0;

        for (int i = 0; i < n; i++)
        {
            double number = double.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine();
        Console.WriteLine("sum = {0}", sum);
    }
}

