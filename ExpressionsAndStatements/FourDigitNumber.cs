using System;
using System.Linq;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Insert four integer numbers: ");
        int number = int.Parse(Console.ReadLine());
        int d = number % 10;
        int c = (number / 10) % 10;
        int b = (number / 100) % 10; 
        int a = (number / 1000) % 10;

        Console.WriteLine("sum = {0}", (a + b + c + d));
        Console.WriteLine("reversed -> {3}{2}{1}{0}", a, b, c, d);
        Console.WriteLine("in order \"dabc\" -> {3}{0}{1}{2}", a, b, c, d);
        Console.WriteLine("in order \"acbd\" -> {0}{2}{1}{3}", a, b, c, d);
    }
}

