using System;
using System.Globalization;
using System.Threading;
using System.Linq;

class SumOf5Numbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        new CultureInfo("en-US");

        string input = Console.ReadLine();
        double[] numbers = input.Split().Select(double.Parse).ToArray();

        Console.WriteLine("Sum = {0}", numbers.Sum());
    }
}

