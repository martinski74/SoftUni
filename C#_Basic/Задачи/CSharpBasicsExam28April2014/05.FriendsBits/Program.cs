using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        string bitString = Convert.ToString(n, 2);
        string friendBits = "0";
        string aloneBits = "0";
        char lastChar = bitString[0];
        int count = 1;

        for (int i = 1; i < bitString.Length; i++)
        {
            if (lastChar == bitString[i])
            {
                count++;
            }
            else
            {
                if (count > 1)
                {
                    friendBits += new String(lastChar, count);

                }
                else
                {
                    aloneBits += lastChar;
                }
                count = 1;
            }
            lastChar = bitString[i];
        }
        if (count > 1)
        {
            friendBits += new String(lastChar, count);

        }
        else
        {
            aloneBits += lastChar;
        }
        Console.WriteLine(Convert.ToInt32(friendBits,2));
        Console.WriteLine(Convert.ToInt32(aloneBits,2));

    }
}

