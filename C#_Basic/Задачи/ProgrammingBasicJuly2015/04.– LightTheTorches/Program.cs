using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string ld = Console.ReadLine();
        char[] rooms = new char[n];
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            rooms[i] = ld[count];
            count++;
            if (count >= ld.Length)
            {
                count = 0;
            }
        }
        int start = n / 2;
        string command = Console.ReadLine();
        while (command != "END")
        {
            string[] arrCommand = command.Split(' ');
            string direction = arrCommand[0];
            int move = int.Parse(arrCommand[1]);

            if (direction == "LEFT")
            {
                move = start - move - 1;
                if (move < 0)
                {
                    move = 0;
                }
                if (move != start)
                {
                    if (rooms[move] == 'L')
                    {
                        rooms[move] = 'D';
                    }
                    else
                    {
                        rooms[move] = 'L';
                    }
                }
            }
            if (direction == "RIGHT")
            {
                move = start + move + 1;
                if (move >= rooms.Length)
                {
                    move = rooms.Length - 1;
                }
                if (move != start)
                {
                    if (rooms[move] == 'L')
                    {
                        rooms[move] = 'D';
                    }
                    else
                    {
                        rooms[move] = 'L';
                    }
                }
            }
            start = move;


            command = Console.ReadLine();
        }

        int countt = 0;
        for (int i = 0; i < rooms.Length; i++)
        {
            if (rooms[i]=='D')
            {
                countt++;
            }
        }
        int prays = 'D' * countt;
        Console.WriteLine(prays);
    }
}

