using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter number: ");
        double n = double.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum = sum + double.Parse(Console.ReadLine());

        }
        Console.WriteLine(sum);
    }
}

