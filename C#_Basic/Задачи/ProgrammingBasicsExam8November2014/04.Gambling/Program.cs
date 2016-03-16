using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        decimal cash = decimal.Parse(Console.ReadLine());
        string[] cards = Console.ReadLine().Split();
        int housStrngth = 0;
        for (int i = 0; i < cards.Length; i++)
        {
            switch (cards[i])
            {
                case "J": housStrngth += 11; break;
                case "Q": housStrngth += 12; break;
                case "K": housStrngth += 13; break;
                case "A": housStrngth += 14; break;

                default: housStrngth += int.Parse(cards[i]);
                    break;
            }
        }
        int winningHands = 0;
        int tottalHands = 0;
        for (int c1 = 2; c1 <= 14; c1++)  //all possibilities
        {
            for (int c2 = 2; c2 <= 14; c2++)
            {
                for (int c3 = 2; c3 <= 14; c3++)
                {
                    for (int c4 = 2; c4 <= 14; c4++)
                    {
                        tottalHands++;
                        int currHandsStength = c1 + c2 + c3 + c4;
                        if (currHandsStength > housStrngth)
                        {
                            winningHands++;
                        }

                    }
                } 
            }
        }

        decimal probability = (decimal)winningHands / tottalHands;
        decimal expectedHands = probability * (cash * 2);

        if (probability <0.5m)
        {
            Console.WriteLine("FOLD");
        }
        else
        {
            Console.WriteLine("DRAW");
        }
        Console.WriteLine("{0:F2}",expectedHands);
       

    }
}

