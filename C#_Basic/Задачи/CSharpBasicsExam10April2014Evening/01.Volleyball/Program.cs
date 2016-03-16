using System;

class Program
{
    static void Main()
    {
        bool isLeap = Console.ReadLine().Contains("leap");
        double holiday = double.Parse(Console.ReadLine());
        double hometown = double.Parse(Console.ReadLine());

        double totalPlays = hometown + (48 - hometown) * 3 / 4 + (holiday*2/3);
        if (isLeap)
        {
            totalPlays += totalPlays * 0.15;
        }
        Console.WriteLine(Math.Floor(totalPlays));
    }
}

