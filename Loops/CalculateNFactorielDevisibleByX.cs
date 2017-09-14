using System;

class CalculateNFactorielDevisibleByX
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());

        double sum = 1;
        int nFac = 1;
        double power = x;

        for (int i = 1; i <= n; i++)
        {
            nFac *= i;
            sum += nFac / x;
            x *= power;
        }
        Console.WriteLine("S = {0:F5}", sum);
    }
}

