using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[][]matrix= new int[n][];
        for (int i = 0; i < matrix.Length; i++)
        {
            matrix[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }
        int primaryDiagonalSum = 0;
        int secondaryDiagonalSum = 0;

        for (int i = 0; i < n; i++)
        {
            primaryDiagonalSum += matrix[i][i];

        }
        for (int i = 0; i < n; i++)
        {
            secondaryDiagonalSum+=matrix[i][matrix[i].Length -1 -i];
        }
        Console.WriteLine(Math.Abs(primaryDiagonalSum - secondaryDiagonalSum));
    }
}

