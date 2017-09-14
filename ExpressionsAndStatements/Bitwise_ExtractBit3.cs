using System;

class Program
{
    static void Main()
    {
        int position = 3;

        Console.Write("n = ");
        int number = int.Parse(Console.ReadLine());

        int thirdBit = number >> position;
        int bit = thirdBit & number;

        Console.WriteLine("The third bit of the number {0} = {1}", number, bit);
    }
}

