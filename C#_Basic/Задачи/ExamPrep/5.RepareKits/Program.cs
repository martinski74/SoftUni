using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        char[] wall = Convert.ToString((long)number, 2).PadLeft(64, '0').ToCharArray();
        int kit = int.Parse(Console.ReadLine());
        int atacks = int.Parse(Console.ReadLine());

        for (int i = 0; i < atacks; i++)
        {
            int target = int.Parse(Console.ReadLine());
            for (int j = 0; j < wall.Length - 1; j++)
            {
                int current = (wall.Length - 1) - target;
                if (wall[current] == '1')
                {
                    wall[current] = '0';
                }
                else
                {
                    wall[current] = '0';
                }
            }
        }
        Array.Reverse(wall);
        for (int i = 0; i < wall.Length - 1; i++)
        {
            if (wall[i] == wall[i + 1])
            {
                if (wall[i] == '0' && kit > 0)
                {
                    wall[i] = '1'; kit--;
                    if (kit<=0)
                    {
                        break;
                    }
                    wall[i + 1] = '1'; kit--;
                    i++;

                }
            }
        }
        Array.Reverse(wall);
        string binResult = new string(wall);
        Console.WriteLine(Convert.ToUInt64(binResult,2));
    }
}

