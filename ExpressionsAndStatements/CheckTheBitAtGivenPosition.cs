using System;

class CheckTheBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("n = ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("p = ");
        int bitPosition = int.Parse(Console.ReadLine());
        
        Console.Write(Convert.ToString(number, 2).PadLeft(16, '0'));

        bool isOne = false;

        int bit = number &= 1 << bitPosition;

        if (bit != 0)
        {
            isOne = true;
        }
        else
        {
            isOne = false;
        }
        Console.WriteLine("-> the bit at the position {0} is one -> {1}", bitPosition, isOne);
    }
}

