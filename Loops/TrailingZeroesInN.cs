using System;


class TrailingZeroesInN
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        int zeroCount = 0;
        int div;

        for (int i = 5; i <= inputNumber; i += 5)
        {
            div = i;
            while (div % 5 == 0)
            {
                div /= 5;
                zeroCount++;
            }
        }
        Console.WriteLine(zeroCount);
    }
}

