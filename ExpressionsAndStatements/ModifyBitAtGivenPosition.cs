using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        int result = 0;
        Console.Write("n = ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("v = ");
        byte setBit = byte.Parse(Console.ReadLine());

        Console.Write("p = ");
        byte bitPosition = byte.Parse(Console.ReadLine());

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));

        if (setBit == 0)
        {
            result = number &= ~(1 << bitPosition);
        }
        else if (setBit == 1)
        {
            result = number |= 1 << bitPosition;
        }
        else
        {
            Console.WriteLine("You must've inserted wrong value for \"v\"!");
        }
        Console.WriteLine("New number -> {0}", result);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
    }
}

