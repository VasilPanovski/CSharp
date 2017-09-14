using System;
using System.Globalization;
using System.Threading;

class SumOfNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        new CultureInfo("en-US");

        Console.Write("a = ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("s = ");
        double thirdNumber = double.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("{0,-5}{1,-5}{2,-5}{3,-5}", "a", "b", "c", "sum");
        Console.WriteLine("{0,-5}{1,-5}{2,-5}{3,-5}", firstNumber, secondNumber, thirdNumber, 
                                                    (firstNumber + secondNumber + thirdNumber));
    }
}

