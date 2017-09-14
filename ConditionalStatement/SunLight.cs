using System;

class SunLight
{
    static void Main()
    {
        Console.SetWindowSize(122, 54);

        int size = int.Parse(Console.ReadLine());

        string dots = new string('.', size * 3 / 2);
        Console.WriteLine("{0}*{0}", dots);

        for (int i = 0; i < size - 1; i++)
        {
            string outsideDots = new string('.', i + 1);
            string insideDots = new string('.', (size * 3 + 1)/ 2 - 3 - i);
            Console.WriteLine("{0}*{1}*{1}*{0}", outsideDots, insideDots);
        }

        for (int i = 0; i < size / 2; i++)
        {
            dots = new string('.', size);
            string asterix = new string('*', size);
            Console.WriteLine("{0}{1}{0}", dots, asterix);
        }

        Console.WriteLine(new string('*', size * 3));

        for (int i = 0; i < size / 2; i++)
        {
            dots = new string('.', size);
            string asterix = new string('*', size);
            Console.WriteLine("{0}{1}{0}", dots, asterix);
        }

        for (int i = 0; i < size - 1; i++)
        {
            string insideDots = new string('.', i + 1);
            string outsideDots = new string('.', (size * 3 + 1) / 2 - 3 - i);
            Console.WriteLine("{0}*{1}*{1}*{0}", outsideDots, insideDots);
        }

        dots = new string('.', size * 3 / 2);
        Console.WriteLine("{0}*{0}", dots);
    }
}

