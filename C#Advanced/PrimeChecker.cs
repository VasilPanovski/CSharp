using System;

class PrimeChecker
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());

        Console.WriteLine(isPrime(number));
    }

    public static bool isPrime(long number)
    {
        int devisor = (int)Math.Sqrt(number);

        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i <= devisor; i++)
        {
            if (number % i == 0)
	        {
		        return false;
            }
        }
        return true;
    }
}

