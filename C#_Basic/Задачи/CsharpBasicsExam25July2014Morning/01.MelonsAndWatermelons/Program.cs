using System;

class Program
{
    static void Main()
    {
        int startDay = int.Parse(Console.ReadLine());
        int nextDays = int.Parse(Console.ReadLine());

        int melons = 0;
        int watermelons = 0;

        for (int i = 0; i < nextDays; i++)
        {
            switch (startDay)
            {
                case 1: watermelons += 1; break;
                case 2: melons += 2; break;
                case 3: watermelons += 1; melons += 1; break;
                case 4: watermelons += 2; break;
                case 5: watermelons += 2; melons += 2; break;
                case 6: watermelons += 1; melons += 2; break;
                case 7: startDay=0; break;
                default:
                    break;
            }
            startDay++;
        }
        if (watermelons > melons)
        {
            Console.WriteLine("{0} more watermelons",watermelons-melons);
        }
        else if (melons > watermelons)
        {
            Console.WriteLine("{0} more melons",melons-watermelons);
        }
        else
        {
            Console.WriteLine("Equal amount: {0}",watermelons);
        }

    }
}

