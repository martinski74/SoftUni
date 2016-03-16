using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char symb = char.Parse(Console.ReadLine());

        int outerLines = n / 2;
        int symbols = 1;
        for (int i = 0; i < n / 2 + 1; i++)
        {
            Console.WriteLine("{0}{1}{0}",new string('-',outerLines),new string(symb,symbols));
            outerLines--;
            symbols += 2;
        }
        outerLines = 0;
        symbols = n;
        for (int i = 0; i < n / 2; i++)
        {
            outerLines++;
            symbols -= 2;
            Console.WriteLine("{0}{1}{0}", new string('-', outerLines), new string(symb, symbols));

        }
    }
}

