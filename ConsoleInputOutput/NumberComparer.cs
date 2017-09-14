using System;
using System.Globalization;
using System.Threading;

class NumberComparer
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        new CultureInfo("en-US");

        Console.Write("a = ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        double secondNumber = double.Parse(Console.ReadLine());

        double result = Math.Max(firstNumber, secondNumber);

        Console.WriteLine("The bigger number is " + result);

    }
}

