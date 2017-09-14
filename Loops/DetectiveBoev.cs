using System;
using System.Text;

class DetectiveBoev
{
    static void Main()
    {
        string secretWord = Console.ReadLine();
        string enqryptedMessage = Console.ReadLine();
        int sum = 0;
        int mask = 0;

        for (int i = 0; i < secretWord.Length; i++)
        {
            sum += secretWord[i];
        }

        while (sum != 0)
        {
            mask += sum % 10;
            sum /= 10;
        }
        if (mask > 10)
        {
            sum = mask;
            int newMask = 0;
            while (sum != 0)
            {
                newMask += sum % 10;
                sum /= 10;
            }
            mask = newMask;
        }

        StringBuilder result = new StringBuilder(enqryptedMessage);
        for (int i = 0; i < result.Length; i++)
        {
            if (result[i] % mask == 0)
            {
                result[i] += (char)mask;
            }
            else
            {
                result[i] -= (char)mask;
            }
        }
        
        for (int i = result.Length - 1; i >= 0; i--)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }
}

