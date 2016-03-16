using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        int a,b,c;
        string num;
        bool OK=false;
       
        for (int i = 111; i < 778; i++)
        {
             int tempSum=0;
            a = i;
            b = a + diff;
            c = b + diff;

            num = a.ToString() + b.ToString() + c;
            Regex r = new Regex("0|8|9");
            if (!r.IsMatch(num)) //if !num.Contains("0") && !num.Contains("8")...9
            {
                for (int j = 0; j < num.Length; j++)
                {
                    tempSum += int.Parse(num[j].ToString());
                }
                if (tempSum==sum && num.Length==9)
                {
                    Console.WriteLine(num);
                    OK = true;
                }
            }
           
        }
        if (!OK)
        {
            Console.WriteLine("No");
        }
    }
}

