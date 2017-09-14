using System;
using System.Globalization;
using System.Threading;

class CompoundTheInterest
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        new CultureInfo("en-US");

        decimal price = decimal.Parse(Console.ReadLine());
        int term = int.Parse(Console.ReadLine());
        double bankInterest = double.Parse(Console.ReadLine());
        double friendInterest = double.Parse(Console.ReadLine());

        decimal bankLoan = price * (decimal)Math.Pow(1 + bankInterest, term);
        decimal friendLoan = price * (decimal)(1 + friendInterest);

        if (friendLoan <= bankLoan)
        {
            Console.WriteLine("{0:F2} Friend", friendLoan);
        }
        else
        {
            Console.WriteLine("{0:F2} Bank", bankLoan);
        }
    }
}

