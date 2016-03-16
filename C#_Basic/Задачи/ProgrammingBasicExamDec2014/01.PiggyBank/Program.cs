using System;

class Program
{
    static void Main()
    {
        const int days = 30;
        const int months = 12;

        double priceOfThank = double.Parse(Console.ReadLine());
        int partyDays = int.Parse(Console.ReadLine());

        int normalDay = (days - partyDays) * 2;
        int partyDay = partyDays * 5;
        double levaPerMonthSaved = normalDay - partyDay;
        double exactlyMonths = priceOfThank / levaPerMonthSaved;
        int result = (int)Math.Ceiling(exactlyMonths);

        double resultYears = result / months;
        double resultMonths = result % (double)months;
        if (partyDays > 8)
        {
            Console.WriteLine("never");
        }
        else
        {
            Console.WriteLine("{0} years, {1} months", resultYears, resultMonths);
        }


    }
}

