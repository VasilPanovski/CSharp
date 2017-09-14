using System;
using System.Linq;

class RandomizeTheNumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("n = ");
        int inputNum = int.Parse(Console.ReadLine());

        int[] numbers = new int[inputNum];
        Random random = new Random();
        
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i + 1;
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            int randNum = random.Next(0, inputNum);
            int temp = numbers[randNum];
            numbers[randNum] = numbers[0];
            numbers[0] = temp;
        }
        Console.WriteLine(string.Join(" ", numbers));
    }
}

