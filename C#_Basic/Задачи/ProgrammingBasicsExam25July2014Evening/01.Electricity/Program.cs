using System;

class Program
{
    static void Main()
    {
        int floors = int.Parse(Console.ReadLine());
        int flats = int.Parse(Console.ReadLine());
        DateTime time = DateTime.Parse(Console.ReadLine());

        int allWats;
        if (time.Hour >= 14 && time.Hour <= 18)
        {
            double noonConsum = ((2 * 100.53) + (2 * 125.90));
            allWats = (int)(noonConsum * floors * flats);
        }
        else if (time.Hour >= 19 && time.Hour <= 23)
        {
            double eveningConsum = (7 * 100.53) + (6 * 125.90);
            allWats = (int)(eveningConsum * flats * floors);
        }
        else if (time.Hour >= 0 && time.Hour <= 8)
        {
            double nightConsum = (1 * 100.53) + (8 * 125.90);
            allWats = (int)(nightConsum * floors * flats);
        }
        else
        {
            allWats = 0;
        }
        Console.WriteLine("{0} Watts",allWats);
    }
}

