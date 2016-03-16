using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        string numberStr = Convert.ToString(n,2).PadLeft(32,'0');
        //Console.WriteLine(numberStr);
        List<char> bitNumber = new List<char>(numberStr);
        for (int i = 0; i < bitNumber.Count; i++)
        {
            
        }

    }
}

