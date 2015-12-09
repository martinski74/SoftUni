using System;

class SumOf5Numbers
{
    static void Main()
    {
        Console.Write("Enter 5 numbers separated by space: ");
        string[] input = Console.ReadLine().Split();

        int sum = 0;

        for (int i = 1; i <= input.Length; i++)
        {
            int cuurentNumb = int.Parse(input[i-1]);
            sum += cuurentNumb;
        }
        Console.WriteLine(sum);

    }
}

