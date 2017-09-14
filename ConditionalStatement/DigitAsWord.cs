using System;
using System.Globalization;
using System.Threading;

class DigitAsWord
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        new CultureInfo("en-US");

        Console.Write("Insert integer number(from 1 to 10): ");
        int number = int.Parse(Console.ReadLine());

        switch (number) 
        {
            case 1: Console.WriteLine("one"); break;
            case 2: Console.WriteLine("two"); break;
            case 3: Console.WriteLine("three"); break;
            case 4: Console.WriteLine("four"); break;
            case 5: Console.WriteLine("five"); break;
            case 6: Console.WriteLine("six"); break;
            case 7: Console.WriteLine("seven"); break;
            case 8: Console.WriteLine("eight"); break;
            case 9: Console.WriteLine("nine"); break;
            case 10: Console.WriteLine("ten"); break;
            default:
                    Console.WriteLine("not a digit"); break;
        }
    }
}

