using System;
using System.Globalization;
using System.Threading;

class MultiplicationSign
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        new CultureInfo("en-US");

        double number;
        int plusSign = 0;
        int minusSign = 0;

        Console.WriteLine("Insert three numbers: ");
        for (int i = 0; i < 3; i++)
        {
            number = double.Parse(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine("0");
                break;
            }
            else if (number > 0)
            {
                plusSign++;
            }
            else
            {
                minusSign++;
            }
        }
        if (plusSign == 1 || plusSign == 3)
        {
            Console.WriteLine("+");
        }
        else if (minusSign == 3 || minusSign == 1)
        {
            Console.WriteLine("-");
        }
    }
}

