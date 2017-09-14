using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        uint n = uint.Parse(Console.ReadLine());
        
        if (0 <= n || n > 100)
        {
            BigInteger nFact = 1,
                       doubleNFact = 1,
                       nFactPlusOne = 1;

            for (uint i = 1; i <= 2*n; i++)
            {
                doubleNFact *= i;
                if (i <= n)
                {
                    nFact *= i;
                    nFactPlusOne *= i + 1;
                }
            }
            Console.WriteLine(doubleNFact / (nFactPlusOne * nFact));
        }
        else
        {
            Console.WriteLine("Out of range!");
        }
    }
}

