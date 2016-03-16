using System;

class Program
{
    static void Main()
    {
        decimal downloadData = decimal.Parse(Console.ReadLine());
        decimal priceOfCinema = decimal.Parse(Console.ReadLine());
        decimal wifeSpending = decimal.Parse(Console.ReadLine());

        decimal downloadTime = downloadData / 2M / 60M / 60M;
        decimal priceOfDownload = downloadTime * wifeSpending;
        decimal numbOfMoviesDowlod = downloadData / 1500M;
        decimal cinemaPrice = numbOfMoviesDowlod * priceOfCinema;

        if (cinemaPrice < priceOfDownload)
        {
            Console.WriteLine("cinema -> {0:F2}lv", cinemaPrice); 
        }
        else
        {
            Console.WriteLine("mall -> {0:F2}lv", priceOfDownload);
        }
    }
}

