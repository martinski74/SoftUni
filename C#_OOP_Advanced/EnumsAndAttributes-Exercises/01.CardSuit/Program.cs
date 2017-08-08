using System;

namespace _01.CardSuit
{
    public class Program
    {
       public static void Main()
        {
            Array suits = Enum.GetValues(typeof(Suit));

            Console.WriteLine("Card Suits:");
            foreach (var cardSuit in suits)
            {
                Console.WriteLine($"Ordinal value: {(int)cardSuit}; Name value: {cardSuit}");
            }
        }
    }
}
