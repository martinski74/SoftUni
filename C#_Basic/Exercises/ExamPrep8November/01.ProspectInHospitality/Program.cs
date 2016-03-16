using System;

class Program
{
    static void Main()
    {
        uint builders = uint.Parse(Console.ReadLine());
        uint receptionists = uint.Parse(Console.ReadLine());
        uint chambermaids = uint.Parse(Console.ReadLine());
        uint technics = uint.Parse(Console.ReadLine());
        uint others = uint.Parse(Console.ReadLine());
        decimal nikiSalary = decimal.Parse(Console.ReadLine());
        decimal usd = decimal.Parse(Console.ReadLine());
        decimal mySalary = decimal.Parse(Console.ReadLine());
        decimal budget = decimal.Parse(Console.ReadLine());

        decimal builderSalary = builders * 1500.04M;
        decimal recepSalary = receptionists * 2102.10M;
        decimal chambSalary = chambermaids * 1465.46M;
        decimal technSalary = technics * 2053.33M;
        decimal otherSalary = others * 3010.98M;
        decimal niki = nikiSalary * usd;

        decimal tottalAmount = builderSalary + recepSalary + chambSalary + technSalary + otherSalary +
            niki + mySalary;
        if (budget >=tottalAmount)
        {
            Console.WriteLine("The amount is: {0:F2} lv.",tottalAmount);
            Console.WriteLine("YES \\ Left: {0:F2} lv.",budget-tottalAmount);
        }
        else
        {
            Console.WriteLine("The amount is: {0:F2} lv.", tottalAmount);
            Console.WriteLine("NO \\ Need more: {0:F2} lv.",Math.Abs(budget-tottalAmount));
        }
    }
}

