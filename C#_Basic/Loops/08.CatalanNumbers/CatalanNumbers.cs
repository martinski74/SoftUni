using System;
using System.Numerics;
//Write a program to calculate the nth Catalan number by given n (1 < n < 100). 
class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger factN = 1;
        BigInteger fact2N = 1;
        BigInteger factNPlus = 1;
        BigInteger result = 0;

        if (n >= 0 && n < 100)
        {
            for (int i = 1; i <= 2 * n; i++)
            {
                fact2N *= i;
                if (i <= n + 1)
                {
                    factNPlus *= i;
                }
                if (i <= n)
                {
                    factN *= i;
                }
            }
            result = fact2N / (factNPlus * factN);
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}

