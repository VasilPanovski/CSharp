using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        Console.Clear();
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (row > 0)
                {
                    matrix[row, col] = matrix[row - 1, col] + 1;
                }
                else
                {
                    matrix[row, col] = col + 1;
                }
                Console.SetCursorPosition(row * 2, col * 2);
                Console.WriteLine(matrix[row, col]);
            }
            
        }
    }
}

