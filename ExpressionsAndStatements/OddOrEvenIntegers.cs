using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("Insert an integer number: ");
        int intNumber = int.Parse(Console.ReadLine());

        bool isOdd = true;

        if (intNumber % 2 == 0)
        {
            isOdd = false;
        }
        else
        {
            isOdd = true;
        }
        Console.WriteLine(isOdd);
    }
}

