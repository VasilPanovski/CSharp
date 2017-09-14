using System;
using System.Globalization;
using System.Threading;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        new CultureInfo("en-US");

        sbyte chosenType = 0;
        do
        {
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");

            chosenType = sbyte.Parse(Console.ReadLine());
        } while (chosenType < 1 || chosenType > 3);

        if (chosenType == 1)
        {
            Console.Write("Please enter a int: ");
            int intChoise = int.Parse(Console.ReadLine());
            Console.WriteLine(intChoise + 1);
        }
        else if (chosenType == 2)
        {
            Console.Write("Please enter a double: ");
            double doubleChoise = double.Parse(Console.ReadLine());
            Console.WriteLine(doubleChoise + 1);
        }
        else
        {
            Console.Write("Please enter a string: ");
            string stringChoise = Console.ReadLine();
            Console.WriteLine(stringChoise + '*');
        }
    }
}

