using System;
using System.Globalization;
using System.Threading;

class DreamItem
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        string[] input = Console.ReadLine().Split('\\');

        decimal lvPerHour = decimal.Parse(input[1]);
        int hours = int.Parse(input[2]);
        decimal itemPrice = decimal.Parse(input[3]);
        int workDays = 0;
        decimal salary = 0;

        switch (input[0])
	        {
            case "Jan": workDays = 21; break;
            case "Feb": workDays = 18; break;
            case "Mar": workDays = 21; break;
            case "Apr": workDays = 20; break;
            case "May": workDays = 21; break;
            case "June":workDays = 20; break;
            case "July":workDays = 21; break;
            case "Aug": workDays = 21; break;
            case "Sept":workDays = 20; break;
            case "Oct": workDays = 21; break;
            case "Nov": workDays = 20; break;
            case "Dec": workDays = 21; break;
		        default: break;
	        }

        salary = (decimal)(workDays * lvPerHour * hours);

        if (salary >= 700)
        {
            salary += salary * 0.1m; 
        }

        if (salary >= itemPrice)
        {
            Console.WriteLine("Money left = {0:F2} leva.", salary - itemPrice);
        }
        else
        {
            Console.WriteLine("Not enough money. {0:F2} leva needed.", itemPrice - salary);
        }
    }
}

