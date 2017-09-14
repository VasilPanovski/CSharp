using System;
using System.Collections.Generic;

class PrimesInGivenRange
{
    static void Main()
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());

        Console.WriteLine(string.Join(", ", FindPrimesInRange(startNum, endNum))); 
    }

    static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primesInRange = new List<int>();

        for (int currentNum = startNum; currentNum <= endNum; currentNum++)
			{
                if (isPrime(currentNum))
	            {
                    primesInRange.Add(currentNum);
	            }
			}
        return primesInRange;
    }

    static bool isPrime(int number)
    {
        int devisor = (int)Math.Sqrt(number);

        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i <= devisor; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}

