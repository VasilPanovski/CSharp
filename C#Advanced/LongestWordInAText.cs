using System;
using System.Collections.Generic;
using System.Linq;

class LongestWordInAText
{
    static void Main()
    {
        Console.WriteLine("Insert the text:");
        string text = Console.ReadLine().Trim();

        string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?', '-', ':' }, StringSplitOptions.RemoveEmptyEntries);
        string longestWord = words[0];

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > longestWord.Length)
            {
                longestWord = words[i];
            }
        }
        Console.WriteLine();
        Console.WriteLine("The longest word is \"{0}\" ", longestWord);
    }
}

