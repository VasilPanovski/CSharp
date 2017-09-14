using System;

class MagicWand
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string firstLine = new string('.', (n * 3 + 1) / 2);
        Console.WriteLine("{0}*{0}", firstLine);

        int count = 1;
        for (int i = 0; i < (n + 1) / 2; i++)
        {
            string outSiteDots = new string('.', (3 * n - 1) / 2 - i);
            string midleDots = new string('.', count);

            Console.WriteLine("{0}*{1}*{0}", outSiteDots, midleDots);
            count += 2;
        }

        string asterix = new string('*', n);
        string dots = new string('.', (3 * n + 2) - 2 * n);

        Console.WriteLine("{0}{1}{0}", asterix, dots, asterix);

        for (int i = 1; i <= n / 2; i++)
        {
            string outSiteDots = new string('.', i);
            string midleDots = new string('.', 3 * n - 2*i);

            Console.WriteLine("{0}*{1}*{0}", outSiteDots, midleDots);
        }

        for (int i = 0; i < n / 2; i++)
        {
            string outSiteDots = new string('.', n / 2  - 1 - i);
            string midleDots = new string('.', n / 2);
            string midleOutDots = new string('.', i);
            string insiteDots = new string('.', n);

            Console.WriteLine("{0}*{1}*{2}*{3}*{2}*{1}*{0}", outSiteDots, midleDots, midleOutDots, insiteDots);
        }

        asterix = new string('*', (n + 1) / 2);
        dots = new string('.', n / 2);
        string dotsInsite = new string('.', n);

        Console.WriteLine("{0}{1}*{2}*{1}{0}", asterix, dots, dotsInsite);

        for (int i = 0; i < n; i++)
        {
            dots = new string('.', n);

            Console.WriteLine("{0}*{0}*{0}", dots);
        }

        asterix = new string('*', n + 2);

        Console.WriteLine("{0}{1}{0}", dots, asterix, dots);
    }
}

