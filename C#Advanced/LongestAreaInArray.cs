using System;
using System.Linq;

class LongestAreaInArray
{
    static void Main()
    {
        int wordsCount = int.Parse(Console.ReadLine());
        string[] words = new string[wordsCount];

        for (int i = 0; i < words.Length; i++)
        {
            words[i] = Console.ReadLine();
        }

        int length = 0;
        string value = string.Empty;

        for (int i = 0; i < words.Length; i++)
        {
            int count = 0;

            for (int j = i; j < words.Length; j++)
            {
                if (words[i] == words[j])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            if (length < count)
            {
                length = count;
                value = words[i];
            }
        }
        Console.WriteLine(length);
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(value);
        }
    }
}

