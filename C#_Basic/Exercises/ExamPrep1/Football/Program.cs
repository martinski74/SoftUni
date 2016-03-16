using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        decimal n = decimal.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        int arsenalPoints = 0;
        int chelseaPoints = 0;
        int manchesterCityPoints = 0;
        int manchesterUnitedPoints = 0;
        int liverpoolPoints = 0;
        int evertonPoints = 0;
        int southamptonPoints = 0;
        int tottenhamPoints = 0;
        int payment = 0;
        while (input!="End of the league.")
        {
            string[] playGame = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string team1 = playGame[0];
            string status = playGame[1];
            string team2 = playGame[2];

            int team1Points = 0;
            int team2Points = 0;

            if (status=="X")
            {
                team1Points += 1;
                team2Points += 1;
            }
            else if (status=="1")
            {
                team1Points += 3;
            }
            else if (status=="2")
            {
                team2Points += 3;
            }

            switch (team1)
            {
                case "Arsenal": arsenalPoints += team1Points; break;
                case "Chelsea": chelseaPoints += team1Points; break;
                case "Everton": evertonPoints += team1Points; break;
                case "Liverpool": liverpoolPoints += team1Points; break;
                case "ManchesterCity": manchesterCityPoints += team1Points; break;
                case "ManchesterUnited": manchesterUnitedPoints += team1Points; break;
                case "Southampton": southamptonPoints += team1Points; break;
                case "Tottenham": tottenhamPoints += team1Points; break;
            }
            switch (team2)
            {
                case "Arsenal": arsenalPoints += team2Points; break;
                case "Chelsea": chelseaPoints += team2Points; break;
                case "Everton": evertonPoints += team2Points; break;
                case "Liverpool": liverpoolPoints += team2Points; break;
                case "ManchesterCity": manchesterCityPoints += team2Points; break;
                case "ManchesterUnited": manchesterUnitedPoints += team2Points; break;
                case "Southampton": southamptonPoints += team2Points; break;
                case "Tottenham": tottenhamPoints += team2Points; break;
            }
            payment++;
            input = Console.ReadLine();

        }

        decimal total = (payment * n) * 1.94m;
        Console.WriteLine("{0:F2}lv.",total);
        Console.WriteLine("Arsenal - {0} points.", arsenalPoints);
        Console.WriteLine("Chelsea - {0} points.", chelseaPoints);
        Console.WriteLine("Everton - {0} points.", evertonPoints);
        Console.WriteLine("Liverpool - {0} points.", liverpoolPoints);
        Console.WriteLine("Manchester City - {0} points.", manchesterCityPoints);
        Console.WriteLine("Manchester United - {0} points.", manchesterUnitedPoints);
        Console.WriteLine("Southampton - {0} points.", southamptonPoints);
        Console.WriteLine("Tottenham - {0} points.", tottenhamPoints);
        
    }
}

