using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.KnightPath
{
    class Program
    {
        static void Main()
        {
            int[,] board = new int[8, 8];
            int row = 0;
            int col = 7;
            board[0, 7] = 1;
            int sum = 0;
            bool checker = false;


            while (true)
            {
                int backupCol = col;
                int backupRow = row;
                try
                {

                    string[] command = Console.ReadLine().Split();
                    if (command[0] == "stop")
                    {
                        break;
                    }
                    string directionX = command[0];
                    string directionY = command[1];
                    switch (directionX)
                    {
                        case "left": col -= 2; break;
                        case "right": col += 2; break;
                        case "up": row -= 2; break;
                        case "down": row += 2; break;

                    }
                    switch (directionY)
                    {
                        case "left": col -= 1; break;
                        case "right": col += 1; break;
                        case "up": row -= 1; break;
                        case "down": row += 1; break;
                    }
                    if (board[row, col] == 1)
                    {
                        board[row, col] = 0;
                    }
                    else
                    {
                        board[row, col] = 1;

                    }
                }
                catch (Exception)
                {
                    row = backupRow;
                    col = backupCol;
                    continue;
                }
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    sum += board[i, j];
                }
            }
            if (sum == 0)
            {
                Console.WriteLine("[Board is empty]");
                return;

            }

            for (int i = 0; i < 8; i++)
            {
                string result = "";

                for (int j = 0; j < 8; j++)
                {
                    result += "" + board[i, j];
                }
                int num = Convert.ToInt32(result, 2);
                if (num > 0)
                {
                    checker = false;
                    Console.WriteLine(num);
                }
            }
        }
    }
}
