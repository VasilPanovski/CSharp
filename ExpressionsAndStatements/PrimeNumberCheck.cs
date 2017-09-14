using System;

class PrimeNumberCheck
{
    static void Main()
    {
        bool isPrime = true;
        int primeCount = 0;

        Console.Write("Insert your number(number<=100): ");
        int number = int.Parse(Console.ReadLine());

        if (number <= 1)
        {
            Console.WriteLine("This number is prime -> False");
        }
        else
        {
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    primeCount++;
                }
            }

            if (primeCount > 2)
            {
                isPrime = false;
            }
            Console.WriteLine("This number is prime -> " + isPrime);
        }
    }
}

