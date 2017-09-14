using System;
using System.Numerics;

class CalculateFactorials
{
    static void Main()
    {
        uint n, k;

        Console.Write("n = ");
        n = uint.Parse(Console.ReadLine());

        Console.Write("k = ");
        k = uint.Parse(Console.ReadLine());

        if (1 < k && k < n && n < 100)
        {
            BigInteger nFact = 1;
            BigInteger kFact = 1;
            int count = 1;

            for (uint i = n - k + 1; i <= n; i++)
            {
                nFact *= i;
                if (count <= k)
                {
                    kFact *= count;
                    count++;
                }
            }
            Console.WriteLine(nFact / kFact);
        }
        else
        {
            Console.WriteLine("Out of range!");
        }
    }
}

