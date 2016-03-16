using System;

class Program
{
    static void Main()
    {
        int reservedBeers = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        long beersCount = 0;
        while (input != "Exam Over")
        {
            string[] strInput = input.Split();
            long amount = long.Parse(strInput[0]);
            string type = strInput[1];

            switch (type)
            {
                case "beers": beersCount += amount; break;
                case "cases": beersCount += amount * 24; break;
                case "sixpacks": beersCount += amount * 6; break;
            }

            input = Console.ReadLine();
        }
        beersCount = beersCount - (beersCount / 100);
        if (beersCount >= reservedBeers)
        {
            long beersLeft = beersCount - reservedBeers;
            long cases = beersLeft / 24;
            beersLeft = beersLeft % 24;
            long sixpax = beersLeft / 6;
            beersLeft = beersLeft % 6;
            Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers."
                , cases, sixpax, beersLeft);
        }
        else
        {
            long beersNeded = reservedBeers - beersCount;
            long cases = beersNeded / 24;
            beersNeded = beersNeded % 24;
            long sixpax = beersNeded / 6;
            beersNeded = beersNeded % 6;
            Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers."
                ,cases,sixpax,beersNeded);
        }
    }
}

