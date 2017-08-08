﻿using System;

public class Program
{
    public static void Main()
    {
        var rankToString = Console.ReadLine();
        var suitToString = Console.ReadLine();

        Rank rank = (Rank)Enum.Parse(typeof(Rank), rankToString);
        Suit suit = (Suit)Enum.Parse(typeof(Suit), suitToString);

        var card = new Card(rank, suit);
        Console.WriteLine(card);
    }
}

