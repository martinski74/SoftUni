using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
      
        bool isOk = false;
        int a, b, c;
        for (int i = 555; i <= 999; i++)
        {
            a = i;
            b = a + diff;
            c = b + diff;
            if (c>999)
            {
                break;
            }
            string strNumb =""+ a + b + c;
            Regex r = new Regex("0|1|2|3|4");
            if (r.IsMatch(strNumb))
            {
                continue; 
            }
            int targetNum = 0;
            for (int j = 0; j < strNumb.Length; j++)
            {
                targetNum += Convert.ToInt32(Convert.ToString(strNumb[j]));
            }
            if (targetNum==sum)
            {
                Console.WriteLine(strNumb);
                isOk = true;
            }
           
        }
        if (!isOk)
        {
            Console.WriteLine("No");
        }

    }
}

