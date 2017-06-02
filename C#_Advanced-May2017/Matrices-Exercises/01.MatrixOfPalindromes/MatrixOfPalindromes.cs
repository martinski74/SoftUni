using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main()
        {
            var tokens = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
            var matrix = new string[tokens[0], tokens[1]];
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = row, colIndex = 0; colIndex < matrix.GetLength(1); col++, colIndex++)
                {
                    matrix[row, colIndex] = $"{alphabet[row]}{alphabet[col]}{alphabet[row]}";
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
