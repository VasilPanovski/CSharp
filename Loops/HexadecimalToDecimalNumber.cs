using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.Write("Insert hexadecimal number: ");
        string hexNumber = Console.ReadLine().ToUpper();
        long decNumber = 0;
        long power = 1;

        for (int index = hexNumber.Length - 1; index >= 0; index--)
        {
            int currentNumber;
            switch (hexNumber[index])
            {
                case 'A': currentNumber = 10; break;
                case 'B': currentNumber = 11; break;
                case 'C': currentNumber = 12; break;
                case 'D': currentNumber = 13; break;
                case 'E': currentNumber = 14; break;
                case 'F': currentNumber = 15; break;
                default: currentNumber = (int)hexNumber[index] - 48;
                    break;
            }
            decNumber += currentNumber * power;
            power *= 16;
        }
        Console.WriteLine("Decimal -> {0}", decNumber);
    }
}

