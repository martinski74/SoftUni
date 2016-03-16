using System;

class Program
{
    static void Main()
    {
        string leap = Console.ReadLine();
        int holidaysInYear = int.Parse(Console.ReadLine());
        int weekendHometown = int.Parse(Console.ReadLine());

        double holidayPlays = holidaysInYear / 2.0;
        double normalWeekednPlays = (52 - weekendHometown);
        normalWeekednPlays = normalWeekednPlays * 2 / 3;

        double result = holidayPlays + normalWeekednPlays + weekendHometown; 
        if (leap=="t")
        {
            result += 3;
        }
       
        Console.WriteLine((int)result);
    }
}

