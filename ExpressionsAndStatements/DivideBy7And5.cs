using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.Write("Insert an integer number: ");
        int number = int.Parse(Console.ReadLine());

        bool canDivided = false;

        if (number % 5 == 0 && number % 7 == 0)
        {
            canDivided = true;
        }
        else
        {
            canDivided = false;
        }
        Console.WriteLine("Can be divided - > {0}", canDivided);
    }
}

