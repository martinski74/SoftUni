using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        string num = "";
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            num += Convert.ToString(number,2).PadLeft(8,'0');

        }
        char[] bits = num.ToCharArray();
        for (int i = 0; i < bits.Length; i+=step)
        {
            if (bits[i]=='0')
            {
                bits[i]='1';
            }
            else
            {
                bits[i]='0';
            }
        }
        num = new String(bits);
        for (int i = 0; i < num.Length; i+=8)
        {
            Console.WriteLine(Convert.ToInt32(num.Substring(i,8),2));
 
        }
    }
}

