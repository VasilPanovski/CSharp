using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int nMembers = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;
        int c = 0;

        for (int next = 0; next < nMembers; next++)
        {
            a = b;
            b = c;
            c = a + b;
            Console.Write(c + " ");
        }
        
    }
}

