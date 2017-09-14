using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

class TheFootballStatitician
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        new CultureInfo("en-US");

        float payment = float.Parse(Console.ReadLine());

        string imputLine = Console.ReadLine();
        int pointsArs = 0, pointsChls = 0, pointsManCity = 0, pointsManUtd = 0, pointsLvp = 0, pointsEvtn = 0, pointsSHam = 0, pointsTot = 0;
        int counter = 0;

        while (imputLine != "End of the league.") 
        {
            string[] currentMach = imputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (currentMach[1] == "X")
            {
                switch (currentMach[0])
                {
                    case "Arsenal": pointsArs++; break;
                    case "Chelsea": pointsChls++; break;
                    case "ManchesterCity": pointsManCity++; break;
                    case "ManchesterUnited": pointsManUtd++; break;
                    case "Liverpool": pointsLvp++; break;
                    case "Everton": pointsEvtn++; break;
                    case "Southampton": pointsSHam++; break;
                    case "Tottenham": pointsTot++; break;
                    default: Console.WriteLine("No such team"); break;
                }
                switch (currentMach[2])
                {
                    case "Arsenal": pointsArs++; break;
                    case "Chelsea": pointsChls++; break;
                    case "ManchesterCity": pointsManCity++; break;
                    case "ManchesterUnited": pointsManUtd++; break;
                    case "Liverpool": pointsLvp++; break;
                    case "Everton": pointsEvtn++; break;
                    case "Southampton": pointsSHam++; break;
                    case "Tottenham": pointsTot++; break;
                    default: Console.WriteLine("No such team"); break;
                }
            }
            if (currentMach[1] == "1")
            {
                switch (currentMach[0])
                {
                    case "Arsenal": pointsArs += 3; break;
                    case "Chelsea": pointsChls += 3; break;
                    case "ManchesterCity": pointsManCity += 3; break;
                    case "ManchesterUnited": pointsManUtd += 3; break;
                    case "Liverpool": pointsLvp += 3; break;
                    case "Everton": pointsEvtn += 3; break;
                    case "Southampton": pointsSHam += 3; break;
                    case "Tottenham": pointsTot += 3; break;
                    default: Console.WriteLine("No such team"); break;
                }
            }
            if (currentMach[1] == "2")
            {
                switch (currentMach[2])
                {
                    case "Arsenal": pointsArs += 3; break;
                    case "Chelsea": pointsChls += 3; break;
                    case "ManchesterCity": pointsManCity += 3; break;
                    case "ManchesterUnited": pointsManUtd += 3; break;
                    case "Liverpool": pointsLvp += 3; break;
                    case "Everton": pointsEvtn += 3; break;
                    case "Southampton": pointsSHam += 3; break;
                    case "Tottenham": pointsTot += 3; break;
                    default: Console.WriteLine("No such team"); break;
                }
            }
            counter++;
            imputLine = Console.ReadLine();
        }

        Console.WriteLine();

        string[] league = new string[]
        { "Arsenal", "Chelsea", "Everton", "Liverpool", "Manchester City", "Manchester United", "Southampton", "Tottenham" };
        
        double sum = counter * payment * 1.94;
        Console.WriteLine("{0:F2}lv.", sum);

        for (int index = 0; index < league.Length; index++)
        {
            switch (league[index])
            {
                case "Arsenal": Console.WriteLine("Arsenal - {0} points.", pointsArs); ; break;
                case "Chelsea": Console.WriteLine("Chelsea - {0} points.", pointsChls); break;
                case "Manchester City": Console.WriteLine("Manchester City - {0} points.", pointsManCity); break;
                case "Manchester United": Console.WriteLine("Manchester United - {0} points.", pointsManUtd); ; break;
                case "Liverpool": Console.WriteLine("Liverpool - {0} points.", pointsLvp); break;
                case "Everton": Console.WriteLine("Everton - {0} points.", pointsEvtn); break;
                case "Southampton": Console.WriteLine("Southampton - {0} points.", pointsSHam); break;
                case "Tottenham": Console.WriteLine("Tottenham - {0} points.", pointsTot); break;
                default:  break;
            }
        }
        Console.WriteLine();
    }
}

