using System;

class NFactDivideByKFact
{
    static void Main()
    {
        uint n, k;
        uint nFact = 1;
        uint kFact = 1;

            Console.Write("n = ");
            n = uint.Parse(Console.ReadLine());

            Console.Write("k = ");
            k = uint.Parse(Console.ReadLine());
            if (1 < k && k < n && n < 100)
            {
                for (uint i = 1; i <= n; i++)
                {
                    nFact *= i;
                    if (i <= k)
                    {
                        kFact *= i;
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

