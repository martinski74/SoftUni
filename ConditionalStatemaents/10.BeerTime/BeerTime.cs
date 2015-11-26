using System;
using System.Globalization;
class BeerTime
{
    static void Main()
    {
        Console.Write("Enter a time: ");
        try
        {
            DateTime time = DateTime.Parse(Console.ReadLine());

            if (time.Hour >= 13 || time.Hour < 3)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid time");

        }

    }
}

