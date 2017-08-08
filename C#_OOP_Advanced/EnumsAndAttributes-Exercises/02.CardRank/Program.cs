using System;

public class Program
{
    public static void Main()
    {
        Array ranks = typeof(CardRank).GetEnumValues();

        Console.WriteLine("Card Ranks:");
        foreach (var rank in ranks)
        {
            Console.WriteLine($"Ordinal value: {(int)rank}; Name value: {rank}");
        }
    }
}

