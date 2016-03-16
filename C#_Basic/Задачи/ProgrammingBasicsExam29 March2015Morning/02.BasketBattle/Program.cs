using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        string firstPlayer = Console.ReadLine();
        int numberOfRounds = int.Parse(Console.ReadLine());

        int rounds = 0;
        int simeonScore = 0;
        int nakovScore = 0;

        for (int i = 0; i <= numberOfRounds; i++)
        {
            rounds++;
            if (firstPlayer == "Simeon")
            {
                int points = int.Parse(Console.ReadLine());
                string info = Console.ReadLine();

                if (info == "success")
                {
                    if (simeonScore + points <= 500)
                    {
                        simeonScore += points;
                    }
                }
                if (simeonScore == 500)
                {
                    Console.WriteLine("Simeon");
                    Console.WriteLine(rounds);
                    Console.WriteLine(nakovScore);
                    return;
                }
                points = int.Parse(Console.ReadLine());
                info = Console.ReadLine();

                if (info == "success")
                {
                    if (nakovScore + points <= 500)
                    {
                        nakovScore += points;
                    }
                }

                firstPlayer = "Nakov";

                if (nakovScore == 500)
                {
                    Console.WriteLine("Nakov");
                    Console.WriteLine(rounds);
                    Console.WriteLine(simeonScore);
                    return;
                }
            }
            else
            {
                int points = int.Parse(Console.ReadLine());
                string info = Console.ReadLine();

                if (info=="success")
                {
                    if (simeonScore+points<=500)
                    {
                        simeonScore += points;
                    }
                }
                firstPlayer = "Simeon";
                if (simeonScore==500)
                {
                    Console.WriteLine("Simeon");
                    Console.WriteLine(rounds);
                    Console.WriteLine(nakovScore);
                    return;
                }
            }

        }
        if (simeonScore==nakovScore)
        {
            Console.WriteLine("DRAW");
            Console.WriteLine(simeonScore);
        }
        else if (simeonScore > nakovScore)
        {
            Console.WriteLine("Simeon");
            Console.WriteLine(simeonScore-nakovScore);
        }
        else
        {
            Console.WriteLine("Nakov");
            Console.WriteLine(nakovScore-simeonScore);
        }

    }
}

