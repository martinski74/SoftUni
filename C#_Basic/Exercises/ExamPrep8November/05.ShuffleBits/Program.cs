using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        uint m = uint.Parse(Console.ReadLine());
        string first = Convert.ToString(n, 2).PadLeft(32, '0');
        string second = Convert.ToString(m, 2).PadLeft(32, '0');
        string result = "";
        if (n >= m)
        {
            for (int i = 0; i < 32; i++)
            {
                result += "" + first[i] + second[i];
            }
        }
        else
        {
            for (int i = 0; i < 31; i += 2)
            {
                result += (first[i].ToString() + first[i + 1]) + ((second[i].ToString() + second[i + 1]));

            }
        }
        Console.WriteLine(Convert.ToUInt64(result, 2));

    }
}

