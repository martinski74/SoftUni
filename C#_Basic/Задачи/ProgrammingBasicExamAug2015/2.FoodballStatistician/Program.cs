using System;

class Program
{
    static void Main()
    {
        int arsenalPoints = 0;
        int chelseaPoints = 0;
        int manchesterCityPoints = 0;
        int manchesterUnitedPoints = 0;
        int liverpoolPoints = 0;
        int evertonPoints = 0;
        int southamptonPoints = 0;
        int tottenhamPoints = 0;

        decimal payment = decimal.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        int pointsTeam1 = 0;
        int pointsTeam2 = 0;
        int machCounter = 0;
        while (input != "End of the league.")
        {
            string[] match = input.Split(' ');
            string team1 = match[0];
            string point = match[1];
            string team2 = match[2];

            if (point=="1")
            {
                pointsTeam1+=3; 
            }
            else if (point=="2")
            {
                pointsTeam2+=3;
            }
            else if (point=="X")
            {
                pointsTeam1++;
                pointsTeam2++;
            }
            switch (team1)
            {
                case "Arsenal": arsenalPoints += pointsTeam1; break;
                case "Chelsea": chelseaPoints += pointsTeam1; break;
                case "Everton": evertonPoints += pointsTeam1; break;
                case "Liverpool": liverpoolPoints += pointsTeam1; break;
                case "Manchester City": manchesterCityPoints += pointsTeam1; break;
                case "Manchester United": manchesterUnitedPoints += pointsTeam1; break;
                case "Southamoton": southamptonPoints += pointsTeam1; break;
                case "Tottenham": tottenhamPoints += pointsTeam1; break;
            }
            switch (team2)
            {
                case "Arsenal": arsenalPoints += pointsTeam2; break;
                case "Chelsea": chelseaPoints += pointsTeam2; break;
                case "Everton": evertonPoints += pointsTeam2; break;
                case "Liverpool": liverpoolPoints += pointsTeam2; break;
                case "Manchester City": manchesterCityPoints += pointsTeam2; break;
                case "Manchester United": manchesterUnitedPoints += pointsTeam2; break;
                case "Southamoton": southamptonPoints += pointsTeam2; break;
                case "Tottenham": tottenhamPoints += pointsTeam2; break;
            }
            machCounter++;
           
            
            input = Console.ReadLine();
        }
        decimal totalPriceInLeva = (machCounter + payment) * 1.94m;
        Console.WriteLine("{0:f2}lv.", totalPriceInLeva);
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

