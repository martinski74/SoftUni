using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char letter = 'A';
        int diez = n - 2;
        int tilda = 0;

        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('~', tilda));

            Console.Write(letter);
            letter = GetNextLetter(letter);
            Console.Write(new string('#', diez));
            diez -= 2;
            Console.Write(letter);
            letter = GetNextLetter(letter);
            Console.Write(new string('~', tilda));
            tilda++;
            Console.WriteLine();
        }
        Console.Write(new string('-', n / 2));
        Console.Write(letter);
        letter = GetNextLetter(letter);
        Console.WriteLine(new string('-', n / 2));

        tilda = n / 2 - 1;
        diez = 1;

        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('~', tilda));
            Console.Write(letter);
            letter = GetNextLetter(letter);
            Console.Write(new string('#', diez));
            Console.Write(letter);
            letter = GetNextLetter(letter);
            Console.WriteLine(new string('~', tilda));
            tilda--;
            diez += 2;
        }

    }
    static char GetNextLetter(char letter)
    {
        letter++;
        if (letter > 'Z')
        {
            letter = 'A';
        }
        return letter;
    }
}

