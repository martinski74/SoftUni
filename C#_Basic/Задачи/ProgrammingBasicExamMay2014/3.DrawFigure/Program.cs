using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(new string('*', n));
        int outDits = 1;
        int astreix = n - 2;
        for (int i = 0; i < n/2; i++)
        {
            Console.WriteLine("{0}{1}{0}",new string('.',outDits),new string('*',astreix));
            outDits++;
            astreix -= 2;
        }
        outDits = n / 2 - 1;
        astreix = 3;
        for (int i = 0; i < n/2-1; i++)
        {
            Console.WriteLine("{0}{1}{0}",new string('.',outDits),new string('*',astreix));
            outDits--;
            astreix += 2;
        }

        Console.WriteLine(new string('*', n));
    }
}

