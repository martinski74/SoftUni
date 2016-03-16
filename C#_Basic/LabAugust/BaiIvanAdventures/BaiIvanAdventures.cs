using System;

class BaiIvanAdventures
{
    static void Main()
    {
        int dayOfWeek = int.Parse(Console.ReadLine());
        decimal aviableMoney = decimal.Parse(Console.ReadLine());
        decimal wantedAlcohol = decimal.Parse(Console.ReadLine());
        decimal boughtAlcohol = 0;

        switch (dayOfWeek)
        {
            case 0: boughtAlcohol = aviableMoney / 25m;
                break;
            case 1: boughtAlcohol = aviableMoney / 21m;
                break;
            case 2: boughtAlcohol = aviableMoney / 14m;
                break;
            case 3: boughtAlcohol = aviableMoney / 17m;
                break;
            case 4: boughtAlcohol = aviableMoney / 45m;
                break;
            case 5: boughtAlcohol = aviableMoney / 59m;
                break;
            case 6: boughtAlcohol = aviableMoney / 42m;
                break;

            default:
                break;
        }
        string drinkStatus;
        if (boughtAlcohol > 1.5m)
        {
            drinkStatus = "very drunk";
        }
        else if (boughtAlcohol >= 1.0m && boughtAlcohol <= 1.5m)
        {
            drinkStatus = "drunk";
        }
        else
        {
            drinkStatus = "sober";
        }
        if (wantedAlcohol < boughtAlcohol)
        {
            Console.WriteLine("Bai Ivan is {0} and very happy and he shared {1:F2} l. of alcohol with his friends",drinkStatus,boughtAlcohol-wantedAlcohol);

        }
        else if (wantedAlcohol== boughtAlcohol)
        {
            Console.WriteLine("Bai Ivan is {0} and happy. He is as drunk as he wanted",drinkStatus);

        }
        else
        {
            Console.WriteLine("Bai Ivan is {0} and quite sad. He wanted to drink another {1:F2} l. of alcohol", drinkStatus, wantedAlcohol - boughtAlcohol);
        }
    }
}

