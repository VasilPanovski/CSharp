using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.Write("n = ");
        int number = int.Parse(Console.ReadLine());
       
        bool isSeven = false;

        if ((number / 100) % 10 == 7)
        {
            isSeven = true;
        }
        else
        {
            isSeven = false;
        }
        Console.WriteLine("Third digit is 7: " + isSeven);
    }
}

