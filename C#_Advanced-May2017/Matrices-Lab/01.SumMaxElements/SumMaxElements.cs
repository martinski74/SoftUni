using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SumMaxElements
{
    class SumMaxElements
    {
        static void Main()
        {
            var matrixSize = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            int[,] matrix = new int[int.Parse(matrixSize[0]), int.Parse(matrixSize[1])];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var inputRow = Console.ReadLine()
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputRow[col];
                }
            }

            int maxSum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            { 
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    maxSum += matrix[row, col];
                }
            }
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(maxSum);
        }
    }
}
