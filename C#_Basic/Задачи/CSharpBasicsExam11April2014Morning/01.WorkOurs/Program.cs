using System;

class Program
{
    static void Main()
    {
        int workHours = int.Parse(Console.ReadLine());
        int daysAviable = int.Parse(Console.ReadLine());
        int percents = int.Parse(Console.ReadLine());

        double needHours = Math.Floor(((daysAviable - daysAviable * 0.1) * 12) * percents / 100);
        double result = needHours - workHours;
        if (workHours <= needHours)
        {
            Console.WriteLine("Yes\n" + result);
        }
        else
        {
            Console.WriteLine("No\n" + result);
        }
    }
}

