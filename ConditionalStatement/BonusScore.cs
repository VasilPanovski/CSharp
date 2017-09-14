using System;

class BonusScore
{   
    static void Main()
    {
        Console.Write("Insert score: ");
        int scoreScale = int.Parse(Console.ReadLine());

        switch (scoreScale)
        {
            case 1: 
            case 2:
            case 3:
                Console.WriteLine(scoreScale * 10); break;
            case 4:
            case 5:
            case 6:
                Console.WriteLine(scoreScale * 100); break;
            case 7:
            case 8:
            case 9:
                Console.WriteLine(scoreScale * 1000); break;
            default:
                Console.WriteLine("Invalid score!"); break;
        }
    }
}

