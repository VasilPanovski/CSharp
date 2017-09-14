using System;

class CalculateGCD
{
    static void Main()
    {
        Console.Write("a = ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("b = ");
        int secondNumber = int.Parse(Console.ReadLine());

        int remain = firstNumber % secondNumber;

        while (remain != 0)
        {
            secondNumber = firstNumber;
            firstNumber = remain;
            remain = firstNumber % secondNumber;
        }
        Console.WriteLine("GCD = {0}", Math.Abs(firstNumber));
    }
}

