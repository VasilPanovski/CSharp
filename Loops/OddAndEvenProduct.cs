using System;
using System.Linq;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.Write("Insert integer numbers separated by space: ");
        
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 0; i < input.Length; i++)
        {
            if (i % 2 == 0)
            {
                evenProduct *= input[i];
            }
            else
            {
                oddProduct *= input[i];
            }
        }
        if (oddProduct == evenProduct)
        {
            Console.WriteLine("Yes \nProduct = {0}", oddProduct);
        }
        else
        {
            Console.WriteLine("No \nOdd product = {0}\nEven product = {1}", evenProduct, oddProduct);
        }
    }
}

