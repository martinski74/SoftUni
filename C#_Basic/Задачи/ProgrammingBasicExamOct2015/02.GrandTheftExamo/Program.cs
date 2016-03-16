using System;

class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long slaped = 0;
        long ecaped = 0;
        long totalBeers = 0;

        for (long i = 0; i < n; i++)
        {
            long thieves = long.Parse(Console.ReadLine());
            long beers = long.Parse(Console.ReadLine());

            if (thieves < 5)
            {
                slaped = slaped + thieves;
                totalBeers += beers;
            }
            else
            {
                ecaped = ecaped + thieves - 5;
                slaped = slaped + 5;
                totalBeers += beers;

            }

        }
        Console.WriteLine("{0} thieves slapped.", slaped);
        Console.WriteLine("{0} thieves escaped.", ecaped);
        Console.WriteLine("{0} packs, {1} bottles.", totalBeers / 6, totalBeers % 6);
    }
}

