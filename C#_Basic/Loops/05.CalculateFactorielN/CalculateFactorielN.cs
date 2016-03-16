using System;
//Write a program that, for a given two integer numbers n and x, calculates the
//sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. Use only one loop.
//Print the result with 5 digits after the decimal point.
class CalculateFactorielN
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());

        double factorial = 1;
        double sum = 1;
        double xPowN = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            xPowN *= x;
            sum=sum+(factorial/xPowN);
        }
        Console.WriteLine("{0:F5}",sum);
    }
}

