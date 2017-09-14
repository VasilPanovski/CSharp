using System;
using System.Collections.Generic;
using System.Linq;


class JoinLists
{
    static void Main()
    {
        Console.WriteLine("Insert elements of the first list sapareted by space:");
        string firstLine = Console.ReadLine().Trim();
        Console.WriteLine();

        Console.WriteLine("Insert elements of the second list sapareted by space:");
        string secondLine = Console.ReadLine().Trim();

        List<int> firstList = new List<int>(Array.ConvertAll(firstLine.Split(' '), int.Parse));
        List<int> secondList = new List<int>(Array.ConvertAll(secondLine.Split(' '), int.Parse));
        List<int> result = new List<int>();

        firstList.AddRange(secondList);
        result = firstList.Distinct().ToList();
        result.Sort();

        Console.WriteLine();
        Console.WriteLine(string.Join(" ", result));
    }
}

