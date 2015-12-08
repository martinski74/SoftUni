using System;
//Write a program that generates and prints all possible cards from a standard deck of 52 cards
//(without the jokers). The cards should be printed using the classical notation
//(like 5♠, A♥, 9♣ and K♦). The card faces should start from 2 to A. Print each
//card face in its four possible suits: clubs, diamonds, hearts and spades.
//Use 2 nested for-loops and a switch-case statement.
class PrintDeckOf52Cards
{
    static void Main()
    {
        string card;
        //card numbers 
        for (int j = 2; j <= 14; j++)
        {
            Console.WriteLine();
            //card face ♠ ♥ ♣ ♦
            for (int i = 3; i <= 6; i++)
            {
                card =j.ToString(); //converting card numbers  to string
                switch (j)
                {
                    case 11: card="J";
                        break;
                    case 12: card = "Q";
                        break;
                    case 13: card = "K";
                        break;
                    case 14: card = "A";
                        break;
                    default: 
                        break;
                }   
                Console.Write(card+(char)i+" ");
            }
        }
        Console.WriteLine();
    }
}

