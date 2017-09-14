using System;

class NumberAsWords
{
    static void Main()
    {
        int number = 0;

        do
        {
            Console.Write("Enter a number(from 0 to 999): ");
            number = int.Parse(Console.ReadLine());
        } while (number < 0 || number >= 1000);

        int thirdDigit = number % 10;
        int secondDigit = (number % 100) / 10;
        int firstDigit = (number % 1000) / 100;

        if (number >= 0 && number < 10)
        {
            switch (number)
            {
                case 0: Console.WriteLine("zero"); break;
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("four"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("nine"); break;
                default:
                    break;
            }   
        }
        if (number > 10 && number < 20)
        {
            switch (number)
            {
                case 11: Console.WriteLine("eleven"); break;
                case 12: Console.WriteLine("twoelve"); break;
                case 13: Console.WriteLine("thirteen"); break;
                case 14: Console.WriteLine("fourteen"); break;
                case 15: Console.WriteLine("fifteen"); break;
                case 16: Console.WriteLine("sexteen"); break;
                case 17: Console.WriteLine("seventeen"); break;
                case 18: Console.WriteLine("eighteen"); break;
                case 19: Console.WriteLine("nineteen"); break;
                default:
                    break;
            }
        }
        else if (firstDigit == 0 && secondDigit != 1 )
        {
            switch (secondDigit)
            {
                case 2: Console.Write("twoenty "); break;
                case 3: Console.Write("thirty "); break;
                case 4: Console.Write("fourty "); break;
                case 5: Console.Write("fifty "); break;
                case 6: Console.Write("sixty "); break;
                case 7: Console.Write("seventy "); break;
                case 8: Console.Write("eighty "); break;
                case 9: Console.Write("ninety "); break;
                default:
                    break;
            }
            switch (thirdDigit)
            {
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("four"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("nine"); break;
                default:
                    break;
            }
        }
        else 
        {
            switch (firstDigit)
            {
                case 1: Console.Write("a hundred and "); break;
                case 2: Console.Write("two hundred and "); break;
                case 3: Console.Write("three hundred and "); break;
                case 4: Console.Write("four hundred and "); break;
                case 5: Console.Write("five hundred and "); break;
                case 6: Console.Write("six hundred and "); break;
                case 7: Console.Write("seven hundred and "); break;
                case 8: Console.Write("eight hundred and "); break;
                case 9: Console.Write("nine hundred and "); break;
                default:
                    break;
            }
            if (secondDigit == 1)
            {
                switch (secondDigit)
                {
                    case 1: Console.WriteLine("eleven"); break;
                    case 2: Console.WriteLine("twoelve"); break;
                    case 3: Console.WriteLine("thirteen"); break;
                    case 4: Console.WriteLine("fourteen"); break;
                    case 5: Console.WriteLine("fifteen"); break;
                    case 6: Console.WriteLine("sexteen"); break;
                    case 7: Console.WriteLine("seventeen"); break;
                    case 8: Console.WriteLine("eighteen"); break;
                    case 9: Console.WriteLine("nineteen"); break;
                    default:
                        break;
                }
            }
            else
            {
                switch (secondDigit)
                {
                    case 2: Console.Write("twoenty "); break;
                    case 3: Console.Write("thirty "); break;
                    case 4: Console.Write("fourty "); break;
                    case 5: Console.Write("fifty "); break;
                    case 6: Console.Write("sixty "); break;
                    case 7: Console.Write("seventy "); break;
                    case 8: Console.Write("eighty "); break;
                    case 9: Console.Write("ninety "); break;
                    default:
                        break;
                }
            }
            switch (thirdDigit)
            {
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("four"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("nine"); break;
                default:
                    break;
            }
        }
    }
}

