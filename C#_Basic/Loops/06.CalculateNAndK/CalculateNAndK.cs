using System;
//Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop. 
class CalculateNAndK
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());
        int factN = 1;
        int factK = 1;

        if (n <= 100 && k > 1)
        {
            for (int i = 1; i <= n; i++)
            {
                factN *= i;
                if (i <= k)
                {
                    factK *= i;
                }
            }
        }
        else
        {
            Console.WriteLine("Wrong input!");
        }

        Console.WriteLine("N!/K!= {0}",factN / factK);
    }
}

