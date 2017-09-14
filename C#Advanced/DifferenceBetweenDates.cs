using System;

class DifferenceBetweenDates
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first date (dd:MM:yyyy): ");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter the second date (dd:MM:yyyy): ");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());

        Console.WriteLine((secondDate - firstDate).TotalDays);
    }
}

