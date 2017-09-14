using System;
using System.Globalization;
using System.Threading;

class FormattingNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("a = ");
        int firstNumber = int.Parse(Console.ReadLine());

        while (firstNumber < 0 || firstNumber > 500)
        {
            Console.WriteLine(@"Invalid value for ""a""!");
            Console.Write("a = ");
            firstNumber = int.Parse(Console.ReadLine());
        }
        Console.Write("b = ");
        float secondNumber = float.Parse(Console.ReadLine());

        Console.Write("c = ");
        float thirdNumber = float.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("{0,-10}|{1,-10}|{2,-10}|{3,-10}|", "a", "b", "c", "result");
        Console.Write("{0,-10}|{1,-10}|{2,-10}|", firstNumber, secondNumber, thirdNumber);
        Console.WriteLine("|{0,-10:X}|{1,-10}|{2,10:00.00}|{3:00.000}|", firstNumber,
                                                               Convert.ToString(firstNumber, 2).PadLeft(10,'0'), 
                                                               secondNumber, 
                                                               thirdNumber);
    }
}

