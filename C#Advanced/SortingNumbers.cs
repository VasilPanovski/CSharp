using System;
using System.Linq;

class SortingNumbers
{
    static void Main()
    {
        Console.Write("Enter the count of the numbers (n): ");
        int count = int.Parse(Console.ReadLine());

        int[] array = new int[count];

        Console.WriteLine("Enter n count of numbers: ");

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);

        Console.WriteLine("Sorted numbers:");

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}

