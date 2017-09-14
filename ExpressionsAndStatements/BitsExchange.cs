using System;

class BitsExchange
{
    static void Main()
    {
        Console.Write("n = ");
        uint inputNumber = uint.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Before -> {0}", Convert.ToString(inputNumber, 2).PadLeft(32, '0'));
        Console.WriteLine();

        uint firstBits = inputNumber & (7 << 3);
        uint secondBits = inputNumber & (7 << 24);
        inputNumber = (inputNumber ^ (firstBits | secondBits) | (secondBits >> 21) | (firstBits << 21));
        
        Console.WriteLine("After ->  {0}", Convert.ToString(inputNumber, 2).PadLeft(32, '0'));
        Console.WriteLine("Result = {0}", inputNumber);
    }
}

