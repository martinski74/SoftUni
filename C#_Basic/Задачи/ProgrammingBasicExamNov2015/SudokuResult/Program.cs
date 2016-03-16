using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int gameCounts = 0;
        int totalSeconds = 0;

        string gameTime = Console.ReadLine();
        while (gameTime != "Quit")
        {
            string[] splitStr = gameTime.Split(':');
            int minutes = int.Parse(splitStr[0]);
            int seconds = int.Parse(splitStr[1]);
            minutes *= 60;
            minutes += seconds;
            gameCounts++;
            totalSeconds += minutes;

            gameTime = Console.ReadLine();

        }
        decimal avg = (decimal)totalSeconds / gameCounts;

        if (avg < 720)
        {
            Console.WriteLine("Gold Star");
        }
        else if (avg >= 720 && avg <= 1440)
        {
            Console.WriteLine("Silver Star");
        }
        else if(avg > 1440)
        {
            Console.WriteLine("Bronze Star");
        }
        Console.WriteLine("Games - {0:F0} \\ Average seconds - {1}",gameCounts,Math.Ceiling(avg));
    }
}

