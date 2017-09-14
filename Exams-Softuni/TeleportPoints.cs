using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

class TeleportPoints
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        new CultureInfo("en-US");

        string inputLine = string.Empty;
        
        for (int i = 0; i < 4; i++)
        {
            inputLine += Console.ReadLine() + " ";
        }

        double radius = double.Parse(Console.ReadLine());
        double step = double.Parse(Console.ReadLine());

        double[] coordinates = inputLine.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

        double wide = Math.Abs(2 * coordinates[0]);
        double tall = Math.Abs(2 * coordinates[1]);

        int countPoints = 0;

        for (double y = coordinates[1] + step; y < tall; y +=step)
        {
            for (double x = coordinates[0] + step; x < wide; x +=step)
            {
                if (Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2) <= Math.Pow(radius, 2))
                {
                    countPoints++;
                }
            }
        }
        Console.WriteLine(countPoints);
    }
}

