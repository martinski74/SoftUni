using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        var type = input[0];
        int rowSize = int.Parse(input[1]);
        int colSize = int.Parse(input[2]);

        if (type == "A")
        {
            PrintMatrix(TypeA(rowSize, colSize));
        }
        else if (type == "B")
        {
            PrintMatrix(TypeB(rowSize, colSize));
        }
        else if (type == "C")
        {
            PrintMatrix(TypeC(rowSize, colSize));
        }
        else if(type == "D")
        {
            PrintMatrix(TypeD(rowSize, colSize));
        }
    }

    static int[,] TypeD(int r, int c)
    {
        int[,] matrix = new int[r, c];
        int number = 1;
        int indexR = 0;
        int indexC = 0;
        while (number <= r * c)
        {
            matrix[indexR, indexC] = number;
            number++; ;

            bool canGoDown = (indexR + 1) < r && matrix[indexR + 1, indexC] == 0 && !((indexC - 1) >= 0 && matrix[indexR, indexC - 1] == 0);
            if (canGoDown) { indexR++; continue; }
            bool canGoRight = (indexC + 1) < c && matrix[indexR, indexC + 1] == 0;
            if (canGoRight) { indexC++; continue; }
            bool canGoUp = (indexR - 1) >= 0 && matrix[indexR - 1, indexC] == 0;
            if (canGoUp) { indexR--; continue; }
            bool canGoLeft = (indexC - 1) >= 0 && matrix[indexR, indexC - 1] == 0;
            if (canGoLeft) { indexC--; continue; }
        }

        return matrix;
    }

    static int[,] TypeC(int r, int c)
    {
        int[,] m = new int[r, c];
        int number = 1;

        for (int i = r - 1; i >= 0; i--)
        {
            int startR = i;
            for (int j = 0; j < r - startR; j++)
            {
                if (j > c - 1) { break; }
                m[startR + j, j] = number; number++;
            }
        }

        for (int i = 1; i < c; i++)
        {
            int startC = i;
            for (int j = 0; j < c - startC; j++)
            {
                if (j > r - 1) { break; }
                m[j, startC + j] = number; number++;
            }
        }

        return m;
    }

    static int[,] TypeB(int rowSize, int colSize)
    {
        int[,] matrix = new int[rowSize, colSize];

        int cellNumber = 1;

        for (int i = 0; i < colSize; i++)
        {
            for (int j = 0; j < rowSize; j++)
            {
                if (i % 2 == 0)
                {
                    matrix[j, i] = cellNumber;
                    cellNumber++;
                }
                else
                {
                    matrix[rowSize - 1 - j, i] = cellNumber;
                    cellNumber++;
                }
            }
        }
        return matrix;
    }

    static int[,] TypeA(int rowSize, int colSize)
    {
        int[,] matrix = new int[rowSize, colSize];
        int cellNumber = 1;
        for (int i = 0; i < rowSize; i++)
        {
            for (int j = 0; j < colSize; j++)
            {
                matrix[j, i] = cellNumber;
                cellNumber++;
            }
        }
        return matrix;
    }

    static void PrintMatrix(int[,] mtrx)
    {
        for (int row = 0; row < mtrx.GetLength(0); row++)
        {
            for (int col = 0; col < mtrx.GetLength(1); col++)
            {
                Console.Write(mtrx[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}

