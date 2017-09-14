using System;

class KingOfThieves
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        char type = char.Parse(Console.ReadLine());

        for (int i = 0; i < (size + 1) / 2; i++)
        {
            string outGem = new string('-', size / 2 - i);
            string gem = new string(type, 1 + 2 * i);

            Console.WriteLine("{0}{1}{0}", outGem, gem);
        }

        for (int i = 1; i <= size / 2; i++)
        {
            string outGem = new string('-', i);
            string gem = new string(type, size - 2*i);

            Console.WriteLine("{0}{1}{0}", outGem, gem);
        }
    }
}

