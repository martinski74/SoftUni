using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outerPoint = (n * 3) + 1;
        Console.WriteLine("{0}*{0}", new string('.', outerPoint / 2));
        int insidePoint = 1;
        outerPoint = (n * 3) - 1;
        for (int i = 0; i < n / 2 + 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outerPoint / 2), new string('.', insidePoint));
            insidePoint += 2;
            outerPoint -= 2;
        }
        Console.WriteLine("{0}{1}{0}", new string('*', n), new string('.', n + 2));
        int insideSpot = (n * 3) - 2;
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', i + 1), new string('.', insideSpot));
            insideSpot -= 2;
        }
        outerPoint = n / 2 - 1;
        Console.WriteLine("{0}*{1}**{2}**{1}*{0}", new string('.', outerPoint), new string('.', n / 2), new string('.', n));


        outerPoint = (n / 2) - 2;
        int midlPoint = n / 2;
        int oneSpot = 1;
        int sreda = n;
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{2}*{3}*{2}*{1}*{0}", new string('.', outerPoint), new string('.', n / 2), new string('.', oneSpot), new string('.', sreda));
            outerPoint--;
            oneSpot++;
        }
        Console.WriteLine("{0}{1}*{2}*{1}{0}", new string('*', n / 2 + 1), new string('.', n / 2), new string('.', n));

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}*{0}*{0}", new string('.', n));
        }
        Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n + 2));
    }
}

