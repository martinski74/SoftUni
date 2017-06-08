using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class SumBigNumbers
{
    public static void Main()
    {
        string a = Console.ReadLine().Trim();
        string b = Console.ReadLine().Trim();


        Console.WriteLine(Add(a,b));
    }

    public static string Add(string a, string b)
    {
        int maxLen = Math.Max(a.Length, b.Length);
        a = a.PadLeft(maxLen + 1, '0');
        b = b.PadLeft(maxLen + 1, '0');

        int[] arr1 = a.Select(x => int.Parse(x.ToString())).ToArray();
        int[] arr2 = b.Select(x => int.Parse(x.ToString())).ToArray();
        int[] sum = new int[arr1.Length];

        int carry = 0;
        for (int i = sum.Length - 1; i >= 0; i--)
        {
            int total = arr1[i] + arr2[i] + carry;
            sum[i] = total % 10;
            if (total > 9) carry = 1;
            else carry = 0;
        }
        return string.Join("", sum.SkipWhile(x => x == 0));
    }
}

