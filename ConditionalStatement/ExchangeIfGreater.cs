using System;
using System.Globalization;
using System.Threading;

class ExchangeIfGreater
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        new CultureInfo("en-US");

        double firstNumber, secondNumber;

        Console.Write("a = ");
        firstNumber = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        secondNumber = double.Parse(Console.ReadLine());
        
        if (firstNumber < secondNumber)
        {
            secondNumber = firstNumber;
        }
        Console.WriteLine("{0} {1}", secondNumber, firstNumber);
    }
}

