using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int albumsEurope = int.Parse(Console.ReadLine());
        decimal priceEuro = decimal.Parse(Console.ReadLine());

        int albumsNAmerica = int.Parse(Console.ReadLine());
        decimal priceNAmerica = decimal.Parse(Console.ReadLine());

        int albumsSAmerica = int.Parse(Console.ReadLine());
        decimal pricePesos = decimal.Parse(Console.ReadLine());

        int concerts = int.Parse(Console.ReadLine());
        decimal profitSinglEuro = decimal.Parse(Console.ReadLine());

        decimal allAlbums = ((albumsEurope * priceEuro) * 1.94m) + ((albumsNAmerica * priceNAmerica) * 1.72m) +
            ((albumsSAmerica * pricePesos) / 332.74m);
        allAlbums *= 0.65m;
        allAlbums *= 0.8m;

        decimal concertProfits = (concerts * profitSinglEuro) * 1.94m;

        if (concertProfits > 100000.00m)
        {
            concertProfits *= 0.85m;
        }
        if (concertProfits>= allAlbums)
        {
            Console.WriteLine("On the road again! We'll see the world and earn {0:F2}lv.",concertProfits);
        }
        else
        {
            Console.WriteLine("Let's record some songs! They'll bring us {0:F2}lv.",allAlbums);
        }

    }
}

