using System;
using System.Globalization;
using System.Threading;
using System.Linq;
using System.Collections.Generic;

class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        new CultureInfo("en-US");

        double biggestNumber = 0;
        double smallestNumber = 0;
        double midleNumber = 0;

        Console.Write("a = ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("c = ");
        double thirdNumber = double.Parse(Console.ReadLine());

        biggestNumber = firstNumber;
        midleNumber = secondNumber;
        smallestNumber = thirdNumber;

        if (firstNumber > secondNumber && firstNumber >= thirdNumber && secondNumber >= thirdNumber)
        {
            biggestNumber = firstNumber;
            smallestNumber = thirdNumber;
            midleNumber = secondNumber;
        }
        else if (secondNumber > firstNumber && secondNumber > thirdNumber && thirdNumber >= firstNumber)
        {
            biggestNumber = secondNumber;
            smallestNumber = firstNumber;
            midleNumber = thirdNumber;
        }
        else if (thirdNumber > firstNumber && thirdNumber > secondNumber && firstNumber >= secondNumber)
        {
            biggestNumber = thirdNumber;
            smallestNumber = secondNumber;
            midleNumber = firstNumber;
        }
        Console.WriteLine("{0} {1} {2}", biggestNumber, midleNumber, smallestNumber);
    }
}

