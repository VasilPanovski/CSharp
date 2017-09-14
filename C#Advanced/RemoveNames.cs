using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNames
{
    static void Main()
    {
        Console.WriteLine("Insert elements of the first list sapareted by space:");
        string firstLine = Console.ReadLine().Trim();
        Console.WriteLine();

        Console.WriteLine("Insert elements of the second list sapareted by space:");
        string secondLine = Console.ReadLine().Trim();

        List<string> firstList = firstLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        List<string> secondList = secondLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        for (int i = 0; i < secondList.Count; i++)
        {
            if (firstList.Contains(secondList[i]))
            {
                firstList.RemoveAll(x => x == secondList[i]);
            }
        }
        Console.WriteLine();
        Console.WriteLine(string.Join(" ", firstList));
    }
}

