using System;
using System.Linq;

class MinMaxSumAndAvgOfNumbers
{
    static void Main()
    {
        Console.Write("N = ");
        int countNumbers = int.Parse(Console.ReadLine());

        int sum, min, max;
        double avg = 0;
        int[] numbers = new int[countNumbers];

        Console.WriteLine("Insert {0} numbers:", countNumbers);
        for (int i = 0; i < countNumbers; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            numbers[i] = currentNumber;
        }

        Console.WriteLine("min = {0}", numbers.Min());
        Console.WriteLine("max = {0}", numbers.Max());
        Console.WriteLine("sum = {0}", numbers.Sum());
        Console.WriteLine("avg = {0:F2}", numbers.Average());
    }
}


