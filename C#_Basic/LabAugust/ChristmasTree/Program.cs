using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string spot="'";
        string xor = "^";
        Console.WriteLine(new string('\'',n) + '^' + new string('\'',n));
        for (int i = 0; i < n/2; i++)
        {
            Console.WriteLine("{0}{1}{0}",
                new string('\'',((n-1)-i)),
                new string('^',(((n*2)+1)-(((n-1)-i)*2))));

        }
        for (int i = 0; i < n/2+1; i++)
        {
            Console.WriteLine("{0}{1}{0}",
                 new string('\'',((n-1)-i)),
                new string('^',(((n*2)+1)-(((n-1)-i)*2))));
        }
        for (int i = 0; i < n/2+1; i++)
        {
            Console.WriteLine("{0}{1} {1}{0}",
                 new string('\'', (n - 1)),
                 new string('|', 1));
        }
       

        Console.WriteLine(new string('-',(n*2)+1));
    }
}

