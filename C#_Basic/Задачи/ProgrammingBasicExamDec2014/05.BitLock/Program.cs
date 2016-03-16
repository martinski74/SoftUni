using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int[] intInput = Array.ConvertAll(input, int.Parse);

        string command = Console.ReadLine();

        while (command != "end")
        {
            string[] order = command.Split(' ');
            if (order[0] == "check")
            {
                int col = int.Parse(order[1]);
                int count = 0;
                foreach (var row in intInput)
                {
                    count += (row >> col) & 1;
                }
                Console.WriteLine(count);

            }
            else
            {
                int row = int.Parse(order[0]);
                string dir = order[1];
                int rotation = int.Parse(order[2]) % 12;

                if (dir == "left")
                {
                    for (int i = 0; i < rotation; i++)
                    {
                        int leftBits = (intInput[row] >> 11) & 1;
                        intInput[row]&=~(1<<11);
                        intInput[row] <<= 1;
                        intInput[row] = intInput[row] | leftBits;

                    }
                }
                else if (dir=="right")
                {
                    for (int i = 0; i < rotation; i++)
                    {
                        int rightBits = intInput[row] & 1;
                        intInput[row] = intInput[row] >> 1;
                        intInput[row] |= rightBits << 11;
                    }
                }
            }


            command = Console.ReadLine();
        }
        foreach (var item in intInput)
        {
            Console.Write(item+" ");
        }
        Console.WriteLine();

    }
}

