using System;
using System.Collections.Generic;
using System.Linq;

class ExtractURLsFromText
{
    static void Main()
    {
        Console.WriteLine("Insert the text:");
        string text = Console.ReadLine().Trim();

        List<string> words = text.Split(new char[] { ' ', '.', ':' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        
        Console.WriteLine();
        for (int i = 0; i < words.Count; i++)
        {
            if (words[i] == "www")
            {
                Console.WriteLine("www." + words[i + 1] + "." + words[i + 2]);
            }
            else if (words[i] == "http")
            {
                if (words[i] == "http" && words[i + 3] == "com")
                {
                    Console.WriteLine("http:" + words[i + 1] + "." + words[i + 2] + "." + "com");
                }
                else
                {
                    Console.WriteLine("http:" + words[i + 1] + "." + words[i + 2]);
                }
            }
        }
    }
}

