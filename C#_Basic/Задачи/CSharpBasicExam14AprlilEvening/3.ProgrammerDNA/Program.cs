using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char letter = char.Parse(Console.ReadLine().ToUpper());
        int dots = 3;
        int multiplayer = 1;

        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('.', dots));
            for (int j = 0; j < 7-2*dots; j++)
            {
                Console.Write(letter);
                letter++;
                if (letter=='H')
                {
                    letter = 'A';
                }
            }
            Console.WriteLine(new string('.', dots));
            dots -= multiplayer;
            if (dots== -1)
            {
                dots = 1;
                multiplayer *= -1;
            }
            else if (dots==4)
            {
                dots = 3;
                multiplayer *= -1;
            }

        }
    }
}

