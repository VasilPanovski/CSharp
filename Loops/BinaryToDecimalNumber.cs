using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Write("Insert binary number: ");
        string binNumber = Console.ReadLine();
        int power = 1;
        long decNumber = 0;

        for (int index = binNumber.Length - 1; index >= 0; index--)
        {
           int number = binNumber[index] - 48;
            decNumber += number * power;
            power *= 2;
        }
        Console.WriteLine("Decimal -> {0}", decNumber);
    }
}

