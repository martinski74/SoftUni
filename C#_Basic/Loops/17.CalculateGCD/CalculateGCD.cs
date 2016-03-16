using System;

class CalculateGCD
{
   
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine(GCD(a,b));
     
    }

    private static int GCD(int a, int b)
    {
        if (a == 0)
            return b;
        if (b == 0)
            return a;

        if (a > b)
            return GCD(a % b, b);
        else
            return GCD(a, b % a);
    }
}

