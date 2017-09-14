using System;
using System.Linq;

class BitwiseLibrary
{
    static void Main()
    {
       const int BITS = 64;

        ulong inputBits = ulong.Parse(Console.ReadLine());
        ulong shootedBits = 0;
        for (int i = 0; i < 3; i++)
        {
            string shoot = Console.ReadLine();
            string[] shootDetails = shoot.Split(' ');
            int shootCenter = int.Parse(shootDetails[0]);
            int shootSize = int.Parse(shootDetails[1]);
            int startBit = shootCenter - shootSize / 2;
            int endBit = shootCenter + shootSize / 2;
            for (int bit = startBit; bit <= endBit; bit++)
            {
                if (bit >= 0 && bit < BITS)
                {
                    shootedBits = shootedBits | ((ulong)1 << bit);
                }
            }
        }
        
        ulong aliveBits = inputBits & (~shootedBits);
        
        //Console.WriteLine(Convert.ToString((long)inputBits, 2).PadLeft(64,'0'));
        //Console.WriteLine(Convert.ToString((long)~shootedBits, 2).PadLeft(64, '0'));
        //Console.WriteLine(Convert.ToString((long)aliveBits, 2).PadLeft(64, '0'));

        ulong rightBits = 0;
        for (int i = 0; i < BITS / 2; i++)
        {
            rightBits += aliveBits & 1;
            aliveBits >>= 1;
        }

        ulong leftBits = 0;
        for (int i = 0; i < BITS / 2; i++)
        {
            leftBits += aliveBits & 1;
            aliveBits >>= 1;
        }

        Console.WriteLine("left: " + leftBits);
        Console.WriteLine("right: " + rightBits);
     }
    

// как да включим или изключим 3 еднакви бита в едно число (пр. е за ulong)
private static void Flip3EqualBitsInNumber()
{
    ulong n = ulong.Parse(Console.ReadLine());
    int endBit = 62;
    while (endBit > 0)
    {
        endBit--;
        ulong last3Bits = (n >> endBit) & 7;
        if (last3Bits == 0 || last3Bits == 7)
        {
            n = n ^ ((ulong)7 << endBit);
            endBit -= 2;
        }
    }

    Console.WriteLine(n);
}


// вмъкване на бит на дадена позиция
private static void InsertBitAtGivenPosition()
{
    uint x = 1567854;
    Console.WriteLine(Convert.ToString(x, 2).PadLeft(31, '0'));

    int position = 3;

    uint insertedBit = 1u << position;

    uint upper = x & (uint.MaxValue << position); // взимаме битовете наляво от позицията на която ще сетваме бит 1
    uint lower = x & ((1u << position) - 1); // взимаме десните битове

    upper = (upper << 1) | insertedBit; // местин веднъж наляво левите битове и сетваме бита на исканата позиция
    x = upper | lower; // залепваме левите и десните битове

    //Console.WriteLine();
    //Console.WriteLine(Convert.ToString(x, 2).PadLeft(31, '0'));
}

// махане на бит от число -> чрез вземане на битовете от ляво и от дясно на бита, който искаме да махнем и залепяне на резултата
private static void RemoveBitAtGivenPosition()
{
    uint x = 27;
    //Console.WriteLine("Number -> {0}", Convert.ToString(x, 2).PadLeft(32, '0'));

    int position = 3; // позицията на бита, който искаме да махнем
    uint upper = x & ((uint.MaxValue - 1) << position); // взимаме битовете наляво от бита, който искаме да махнем
    uint lower = x & ((1u << position) - 1); // взимаме битовете надясно от бита, който искаме да махнем

    x = (upper >> 1) | lower; // залепяме битовете от ляво и от дясно на бита който сме махнали

    //Console.WriteLine("Upper  -> {0}", Convert.ToString(upper, 2).PadLeft(32, '0'));
    //Console.WriteLine("Lower  -> {0}", Convert.ToString(lower, 2).PadLeft(32, '0'));
    //Console.WriteLine("Number2 ->{0}", Convert.ToString(x, 2).PadLeft(32, '0'));
}

// как да сменим бит на позиция( от 0 на 1 и обратно (ревърсваме бита на позиция))
private static void ReverseTheBit()
{
    long number = 8;
    Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

    int position = 1;

    number ^= ((long)1 << position);
    Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
}

// как да разменим групи от битове между две числа
 private static void SwapTheGroupOfBitsBetween2Numbers()
    {
        uint firstNumber = 15;
        uint secondNumber = 784;

        // see the numbers before swapping them bits
        Console.WriteLine("{0}  - > {1}", firstNumber, Convert.ToString(firstNumber, 2).PadLeft(32, '0'));
        Console.WriteLine("{0} - > {1}", secondNumber, Convert.ToString(secondNumber, 2).PadLeft(32, '0'));
        int firstGroup = 0 * 4; // for exaple: from zeroth bit
        int secondGroup = 1 * 4; // for exaple: to fourth bit

        uint fromMask = 15u << firstGroup;
        uint toMask = 15u << secondGroup;
        uint fromByte = (firstNumber & fromMask) >> firstGroup;
        uint toByte = (secondNumber & toMask) >> secondGroup;

        // zeroing the 2 groups that will be swaped
        firstNumber &= ~fromMask;
        secondNumber &= ~toMask;

        // swaping
        firstNumber |= toByte << firstGroup;
        secondNumber |= fromByte << secondGroup;

        Console.WriteLine();
        // see the numbers after swapped bits
        Console.WriteLine("{0}    - > {1}", firstNumber, Convert.ToString(firstNumber, 2).PadLeft(32, '0'));
        Console.WriteLine("{0} - > {1}", secondNumber, Convert.ToString(secondNumber, 2).PadLeft(32, '0'));
    }

// как да взимаме последователно битовете (от ляво на дясно) от две числа
private static void GetTheBitsFrom2Numbers()
{
        uint number1 = uint.Parse(Console.ReadLine());
        //Console.WriteLine(Convert.ToString(number1, 2).PadLeft(32, '0'));

        uint number2 = uint.Parse(Console.ReadLine());
        //Console.WriteLine(Convert.ToString(number2, 2).PadLeft(32, '0'));

        ulong result = 0;

        if (number1 >= number2)
        {
            for (int i = 31; i >= 0; i--)
            {
                result = (result << 1) | ((number1 >> i) & 1); // взимаме съотвтния бит на първото число и го прибавяме към новото
                result = (result << 1) | ((number2 >> i) & 1); // взимаме съотвтния бит на второто число и го прибавяме към новото
            }
        }
        else
        {
            for (int i = 31; i >= 0; i -= 2)
            {
                result = (result << 1) | ((number1 >> i) & 1);
                result = (result << 1) | ((number1 >> i - 1) & 1); // същото упражнение, но взимаме последователно по два бита от двете числа
                result = (result << 1) | ((number2 >> i) & 1);
                result = (result << 1) | ((number2 >> i - 1) & 1);
            }
        }

        Console.WriteLine(result);
}
    }

