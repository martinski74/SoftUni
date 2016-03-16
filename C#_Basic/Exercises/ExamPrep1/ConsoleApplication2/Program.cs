using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        long escaps = long.Parse(Console.ReadLine());
        long slapedThieves = 0;
        long escaped = 0;
        long toalBeers = 0;
        for (int i = 0; i < escaps; i++)
        {
            uint thieves = uint.Parse(Console.ReadLine());
            uint beers = uint.Parse(Console.ReadLine());

            toalBeers += beers;
            if (thieves > 5)
            {
                slapedThieves += 5;
                escaped += thieves - 5;
            }
            else
            {
                slapedThieves += thieves;
                    
            }
        }
       
        Console.WriteLine("{0} thieves slapped.", slapedThieves);
        Console.WriteLine("{0} thieves escaped.", escaped);
        Console.WriteLine("{0} packs, {1} bottles.",toalBeers/6,toalBeers%6);
    }
}

