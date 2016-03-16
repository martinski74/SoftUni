using System;

class Program
{
    static void Main()
    {
        double rubles = double.Parse(Console.ReadLine());
        double dollars = double.Parse(Console.ReadLine());
        double euro = double.Parse(Console.ReadLine());
        double levaB = double.Parse(Console.ReadLine());
        double levaM = double.Parse(Console.ReadLine());

        //all in leva
        rubles = (rubles / 100) * 3.5;
        dollars = dollars * 1.5;
        euro = euro * 1.95;
        levaB = levaB / 2;

        //geting lowest price
        double lowest = double.MaxValue;
        lowest = Math.Min(rubles, lowest);
        lowest = Math.Min(dollars, lowest);
        lowest = Math.Min(euro, lowest);
        lowest = Math.Min(levaB, lowest);
        lowest = Math.Min(levaM, lowest);
        Console.WriteLine("{0:F2}",lowest);
    }
}

