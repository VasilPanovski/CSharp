using System;

class DividableByGivenNumber
{
    static void Main()
    {
        Console.Write("start = ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("end = ");
        int end = int.Parse(Console.ReadLine());

        int counter = 0;
        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
                Console.Write(i + ", ");
            }
        }
        Console.WriteLine("-> {0}", counter);
    }
}

