using System;

class Program
{
    static void Main()
    {
        int weightPounds = int.Parse(Console.ReadLine());
        int higthInches = int.Parse(Console.ReadLine());
        int age = int.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine());
        int workoutsPerWeek = int.Parse(Console.ReadLine());

        double weightKg = weightPounds / 2.2d;
        double heightCm = higthInches * 2.54d;

        double menBmr = 66.5d + (13.75d * weightKg) + (5.003d * heightCm) - (6.755d * age);
        double womanBmr = 655d + (9.563d * weightKg) + (1.850d * heightCm) - (4.676d * age);
        double dciNumbs;

        if (workoutsPerWeek <= 0)
        {
            dciNumbs = 1.2d;
        }
        else if (workoutsPerWeek >= 1 && workoutsPerWeek <= 3)
        {
            dciNumbs = 1.375d;
        }
        else if (workoutsPerWeek >= 4 && workoutsPerWeek <= 6)
        {
            dciNumbs = 1.55d;
        }
        else if (workoutsPerWeek <= 7 && workoutsPerWeek <= 9)
        {
            dciNumbs = 1.725d;
        }
        else
        {
            dciNumbs = 1.9d;
        }

        if (gender=='m')
        {
            Console.WriteLine(Math.Floor(menBmr*dciNumbs));
        }
        else
        {
            Console.WriteLine(Math.Floor(womanBmr*dciNumbs));
        }
    }
}

