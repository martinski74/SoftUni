using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(IsPrime(n));
    }

    public static bool IsPrime(int n)
    {
        bool isPrime = true;

        if (n == 1)
        {
            return false;
        }
        if (n==2)
        {
            return true;
        }
        for (int i = 2; i <= Math.Ceiling(Math.Sqrt(n)); ++i)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }

        }
        return isPrime;

    }
}

