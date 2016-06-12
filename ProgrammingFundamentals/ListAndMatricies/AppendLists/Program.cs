using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> items = Console.ReadLine().Split('|').ToList();
        items.Reverse();
        var resultList = new List<string>();
        foreach (var item in items)
        {
            List<string> nums = item.Split(' ').ToList();
            foreach (var num in nums)
            {
                if (num!="")
                {
                    resultList.Add(num);
                }
            }



          
        }
       
        Console.WriteLine(string.Join(" ",resultList));
    }
}

