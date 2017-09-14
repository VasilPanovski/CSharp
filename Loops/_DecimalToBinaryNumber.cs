using System;

class _DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("Insert an integer number: ");
        long decNumber = long.Parse(Console.ReadLine());
        string binNumber = string.Empty;
        int remain = 1;

        if (decNumber == 0)
        {
            Console.WriteLine("Binary -> 0");
        }
        else
        {
            while (decNumber != 0)
            {
                remain = (int)decNumber % 2;
                decNumber /= 2;
                binNumber = remain + binNumber;  
            }
            Console.WriteLine("Bynary -> " + binNumber);
         }
    }
}

