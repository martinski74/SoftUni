using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger f1 = BigInteger.Parse(Console.ReadLine());
        BigInteger f2 = BigInteger.Parse(Console.ReadLine());
        BigInteger f3 = BigInteger.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        if (n == 1)
        {
            Console.WriteLine(f1);
        }
        else if (n == 2)
        {
            Console.WriteLine(f2);
        }
        else if (n == 3)
        {
            Console.WriteLine(f3);
        }
        else
        {
            for (int i = 4; i <= n; i++)
            {
                BigInteger next = f1 + f2 + f3;
                f1 = f2;
                f2 = f3;
                f3 = next;
            }
            Console.WriteLine(f3);
        }

    }
}

