using System;
using System.Collections.Generic;
using System.Linq;

class ProgrammarDNA
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char symbol = char.Parse(Console.ReadLine());

        if (n < 7 || n > 999)
        {
            Console.WriteLine("Wrong input!");
            return;
        }
        
        int emptyCount = 3;
        int symbolCount = 1;
        string letters = "" + symbol;

        for (int i = 65; i < 69; i++)
        {
            string emptySpace = new string('.', emptyCount);
			string symbols = new string((char) i, symbolCount);
            Console.WriteLine("{0}{1}{0}", emptySpace, letters);
            (int)symbol += i;
            symbolCount += 2;
            emptyCount--;
        }
    }
}

