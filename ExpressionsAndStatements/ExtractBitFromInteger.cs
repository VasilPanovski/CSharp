using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("n = ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("p = ");
        int index = int.Parse(Console.ReadLine());

        int mask = number >> index;
        int bit = number & mask;

        Console.WriteLine("The bit on index {0} = {1}", index, bit);
    }
}

