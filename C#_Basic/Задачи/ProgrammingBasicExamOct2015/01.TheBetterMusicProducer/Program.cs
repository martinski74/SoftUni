using System;

class Program
{
    static void Main()
    {
        int numberOfAlbums = int.Parse(Console.ReadLine());
        decimal priceOfAlbum = decimal.Parse(Console.ReadLine());
        int soldAlbNordAmerica = int.Parse(Console.ReadLine());
        decimal priceInDolars = decimal.Parse(Console.ReadLine());
        int numbOfAlbSouthAmerica = int.Parse(Console.ReadLine());
        decimal priceInPesos = decimal.Parse(Console.ReadLine());
        int numbConserts = int.Parse(Console.ReadLine());
        decimal profitSingleConcert = decimal.Parse(Console.ReadLine());

        decimal totalAlbumsPrice = ((numberOfAlbums * priceOfAlbum) * 1.94M) +
            ((soldAlbNordAmerica * priceInDolars) * 1.72M) +
            ((numbOfAlbSouthAmerica * priceInPesos) / 332.74M);
        totalAlbumsPrice *= 0.65M;
        totalAlbumsPrice *= 0.8M;
        
        decimal totalConcetrIncoms = (numbConserts * profitSingleConcert) * 1.94M;

        if (totalConcetrIncoms > 100000.00M)
        {
            totalConcetrIncoms *= 0.85M;
        }
        if (totalConcetrIncoms >= totalAlbumsPrice)
        {
            Console.WriteLine("On the road again! We'll see the world and earn {0:F2}lv.", totalConcetrIncoms);
        }
        else
        {
            Console.WriteLine("Let's record some songs! They'll bring us {0:F2}lv.", totalAlbumsPrice);
        }


    }
}

