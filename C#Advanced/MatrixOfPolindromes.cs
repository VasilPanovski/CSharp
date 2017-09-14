using System;


class MatrixOfPolindromes
{
    static void Main()
    {
        Console.Write("Enter rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter columns: ");
        int cols = int.Parse(Console.ReadLine());

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("{0}{1}{2} ", (char)(i + 97), (char)(j + i + 97), (char)(i + 97));
            }
            Console.WriteLine();
        }
    }
}

