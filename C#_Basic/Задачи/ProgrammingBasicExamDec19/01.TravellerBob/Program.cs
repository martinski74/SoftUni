using System;

class Program
{
    static void Main()
    {
        string year = Console.ReadLine();
        int contractMonths = int.Parse(Console.ReadLine());
        int familyMonths = int.Parse(Console.ReadLine());

        int travelsContr = 3 * 4 * contractMonths;
        int travFamily = 2 * 2 * familyMonths;
        double travNormal = (((12 - contractMonths - familyMonths) * 12) * 3 / 5.0);

        double tottalTrav = travelsContr + travFamily + travNormal;

        if (year=="leap")
        {
            tottalTrav = tottalTrav * 1.05;
        }
        Console.WriteLine((int)tottalTrav);
    }
}

