using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int dayliMoney = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
       
        int totalMoney = 0;
        int days = 0;
        while (input != "Season Over")
        {
            string[] line = input.Split();
            int hours = int.Parse(line[0]);
            string path = line[1].ToUpper();
            int price = int.Parse(line[2]);
            days++;
            int herbCounter = 0;
            for (int i = 0; i < hours; i++)
            {
                char current = path[i];
                if (current == 'H')
                {
                    herbCounter+=1;
                }
                if (i >= path.Length - 1)
                {
                    i = -1;
                    hours = hours - path.Length;
                }
            }
            totalMoney += herbCounter * price;
            input = Console.ReadLine();
        }
        decimal avgPerDay = (decimal)totalMoney / days;
        if (avgPerDay >= dayliMoney)
        {
            Console.WriteLine("Times are good. Extra money per day: {0:F2}.",avgPerDay-dayliMoney);
        }
        else
        {
            int totalExpenses = dayliMoney * days;
            Console.WriteLine("We are in the red. Money needed: {0}.",totalExpenses-totalMoney);
        }
    }
}

