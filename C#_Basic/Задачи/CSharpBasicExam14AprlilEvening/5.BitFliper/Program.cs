using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());
        string represent = Convert.ToString((long)n, 2).PadLeft(64, '0');
        char[] bitArray = represent.ToCharArray();

        for (int i = 0; i < bitArray.Length - 2; i++)
        {
            if (bitArray[i] == bitArray[i + 1] && bitArray[i + 1] == bitArray[i + 2])
            {
                if (bitArray[i] == '1')
                {
                    bitArray[i] = '0';
                    bitArray[i + 1] = '0';
                    bitArray[i + 2] = '0';
                }
                else if (bitArray[i] == '0')
                {
                    bitArray[i] = '1';
                    bitArray[i + 1] = '1';
                    bitArray[i + 2] = '1';
                }
                i += 2;
            }
        }
       
        Console.WriteLine(Convert.ToUInt64(string.Join("",bitArray),2));

    }
}

