using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        int key = int.Parse(Console.ReadLine());
        string message = Console.ReadLine();
        char[] arr = message.ToUpper().ToCharArray();
        int simbolSum = 0;

        foreach (char ch in arr)
        {
            if (ch >= 'A' && ch <= 'Z')
            {
                simbolSum += ch - 'A' + 1;
            }
            else
            {
                simbolSum += (int)ch;
            }
        }
        StringBuilder listForConverting = new StringBuilder();
        while (simbolSum > 1)
        {
            int newMassage = simbolSum % key;
            simbolSum /= key;
            listForConverting.Append(newMassage);
        }
        if (simbolSum > 0)
        {
            listForConverting.Append(simbolSum);
        }
        Console.Write(key);
        Console.Write(message.Length);
        for (int i = listForConverting.Length-1; i>= 0; i--)
        {
            Console.Write(listForConverting[i]); 
        }
        Console.WriteLine();
       


    }
}

