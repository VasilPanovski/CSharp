using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Linq;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        new CultureInfo("en-US");

        Console.Write("From how many numbers do you want take the biggest one: ");
        int countNumbers = int.Parse(Console.ReadLine());

        List<double> numbers = new List<double>(countNumbers);

        Console.WriteLine("Now insert {0} numbers:", countNumbers);
        for (int i = 0; i < countNumbers; i++)
        {
            double currentNumber = double.Parse(Console.ReadLine());
            numbers.Add(currentNumber);
        }
        double greaterNumber = numbers.Max();
        Console.WriteLine("The max number is " + greaterNumber);
    }
}

