using System;

class FibbonacciNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(CalculateFibNumbers(number));
    }   

    static int CalculateFibNumbers(int number)
    {
        if (number <= 1)
        {
            return 1;
        }
        else
        {
            return CalculateFibNumbers(number - 2) + CalculateFibNumbers(number - 1);
        }
    }
}
 
