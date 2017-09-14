using System;

class NumberFrom1ToN
{
    static void Main()
    {
        Console.Write("N = ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            Console.Write("{0} ", i);
        }
    }
}

