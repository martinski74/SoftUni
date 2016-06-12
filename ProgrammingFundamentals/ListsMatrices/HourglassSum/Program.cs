using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[,] matrix = new int[6, 6];
        FillMatrix(matrix);
        long maxSum = long.MinValue;

        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                long sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                    matrix[row + 1, col + 1]
                    + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
        }
        Console.WriteLine(maxSum);
       
    }

   static void FillMatrix(int[,] matrix)
    {
        for (int row = 0; row < 6; row++)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int col = 0; col < 6; col++)
            {
                matrix[row,col]= input[col];
            }
        }
    }

}

