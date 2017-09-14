using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        int num, minNum, maxNum;

        Console.Write("n = ");
        num = int.Parse(Console.ReadLine());
        Console.Write("min = ");
        minNum = int.Parse(Console.ReadLine());
        Console.Write("max = ");
        maxNum = int.Parse(Console.ReadLine());

        if (minNum <= maxNum)
        {
            Random random = new Random();
            for (int i = 0; i < num; i++)
            {
                Console.Write("{0} ", random.Next(minNum, maxNum + 1)); 
            }    
        }
        else
        {
            Console.WriteLine("You entered min>max!");
        }
    }
}

