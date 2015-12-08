using System;
using System.Numerics;

class FactorialCombinations
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());
        BigInteger factN = 1;
        BigInteger factNK = 1;

        if (1 < k && n > k && n < 100)
        {
            
            for (int i = k + 1; i <= n; i++)
            {
                factN *= i;
            }
         
            for (int j = 1; j <= n - k; j++)
            {
                factNK *= j;
            }
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
        Console.WriteLine(factN / factNK);
    }
}

