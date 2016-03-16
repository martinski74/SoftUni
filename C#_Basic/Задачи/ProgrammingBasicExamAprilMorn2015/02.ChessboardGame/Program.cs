using System;

class Program
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        int blackScore = 0;
        int whiteScore = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (i >= size * size)
            {
                break;
            }
            if (i % 2 == 0 && char.IsUpper(input[i]))
            {
                whiteScore += input[i];
            }
            else if (i % 2 == 0 && char.IsLetterOrDigit(input[i]))
            {
                blackScore += input[i];
            }
            else if (i % 2 != 0 && char.IsUpper(input[i]))
            {
                blackScore += input[i];
            }
            else if (i % 2 != 0 && char.IsLetterOrDigit(input[i]))
            {
                whiteScore += input[i];
            }

        }
        if (whiteScore == blackScore)
        {
            Console.WriteLine("Equal result: {0}", whiteScore);
        }
        else
        {
            Console.WriteLine("The winner is: {0} team", whiteScore > blackScore ? "white" : "black");
            int diferent = whiteScore - blackScore;
            Console.WriteLine(Math.Abs(diferent));
        }

    }
}

