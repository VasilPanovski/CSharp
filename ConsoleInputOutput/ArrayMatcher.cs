using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split('\\');

        string firstArr = input[0];
        string secondArr = input[1];
        string command = input[2];

        string result = string.Empty;

        if (command == "join")
        {
            for (int i = 0; i < firstArr.Length; i++)
            {
                for (int j = 0; j < secondArr.Length; j++)
                {
                    if (firstArr[i] == secondArr[j])
                    {
                        result += firstArr[i];
                        continue;
                    }
                }
            }
        }
        else if (command == "right exclude")
        {
            for (int i = 0; i < firstArr.Length; i++)
            {
                if (!secondArr.Contains(firstArr[i]))
                {
                    result += firstArr[i];
                }
            }
        }
        else if (command == "left exclude")
        {
            for (int i = 0; i < secondArr.Length; i++)
            {
                if (!firstArr.Contains(secondArr[i]))
                {
                    result += secondArr[i];
                }
            }
        }

        char[] sortedResult = result.ToCharArray();
        Array.Sort(sortedResult);

        Console.WriteLine(string.Join("", sortedResult));
    }
}

