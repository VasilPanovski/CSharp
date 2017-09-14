using System;

class Program
{
    static void Main()
    {

        int weight = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
        int age = int.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine());
        int workouts = int.Parse(Console.ReadLine());

        double bmrForMan = 66.5 + (13.75 * (weight / 2.2)) + (5.003 * (height * 2.54)) - (6.755 * age);
        double bmrForWoman = 655 + (9.563 * (weight / 2.2)) + (1.850 * (height * 2.54)) - (4.676 * age);

        double dci = 1.0;

        if (gender == 'm')
        {
            if (workouts <= 0)
            {
                dci = bmrForMan * 1.2;
            }
            else if (workouts > 0 && workouts <= 3)
            {
                dci = bmrForMan * 1.375;
            }
            else if (workouts > 3 && workouts <= 6)
            {
                dci = bmrForMan * 1.55;
            }
            else if (workouts > 6 && workouts <= 9)
            {
                dci = bmrForMan * 1.725;
            }
            else 
            {
                dci = bmrForMan * 1.9;
            }
        }
        else
        {
            if (workouts <= 0)
            {
                dci = bmrForWoman * 1.2;
            }
            else if (workouts > 0 && workouts <= 3)
            {
                dci = bmrForWoman * 1.375;
            }
            else if (workouts > 3 && workouts <= 6)
            {
                dci = bmrForWoman * 1.55;
            }
            else if (workouts > 6 && workouts <= 9)
            {
                dci = bmrForWoman * 1.725;
            }
            else
            {
                dci = bmrForWoman * 1.9;
            }
        }
        Console.WriteLine(Math.Floor(dci));
    }
}

