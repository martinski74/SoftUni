using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class MultyplyBigNumbers
{
    public static void Main()
    {
        string number = Console.ReadLine();
        int multiply = int.Parse(Console.ReadLine());

        number = number.PadLeft(number.Length + 2, '0');
        int[] arr = number.Select(x => int.Parse(x.ToString())).ToArray();
        int[] sum = new int[arr.Length];
        int carry = 0;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            int total = arr[i] * multiply + carry;
            sum[i] = total % 10;
            if (total > 9) carry = total / 10;
            else carry = 0;
        }
        Console.WriteLine(string.Join("", sum.SkipWhile(x => x == 0)));

    }
}

