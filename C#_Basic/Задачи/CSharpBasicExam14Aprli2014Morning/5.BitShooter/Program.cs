using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        string strNumb = Convert.ToString(number, 2).PadLeft(64, '0');
        int pos = 0;
        int size = 0;
        StringBuilder strNumbs = null;
        for (int i = 0; i < 3; i++)
        {
            string[] input = Console.ReadLine().Split();
            int center = int.Parse(input[0]);
            size = int.Parse(input[1]);

            pos = 64 - (center + (size / 2));
            strNumbs = new StringBuilder(strNumb);
            strNumbs.Remove(pos, size);
            strNumbs.Insert(pos, new string('0', size));
        }

        Console.WriteLine(strNumbs.ToString());
        string result =strNumbs.ToString();
        string left = result.Substring(0,32);
        string right = result.Substring(32,32);
        //Console.WriteLine(left+"|"+right);
        int leftCount = 0;
        foreach (var bit in left)
        {
            if (bit=='1')
            {
                leftCount++;
            }
        }
        int rightCount = 0;
        foreach (var bit in right)
        {
            if (bit =='1')
            {
                rightCount++;
            }
        }
        Console.WriteLine("left: {0}", leftCount);
        Console.WriteLine("right: {0}", rightCount);
       

    }
}

