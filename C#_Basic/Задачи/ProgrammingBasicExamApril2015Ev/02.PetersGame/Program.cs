using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.PetersGame
{
    class Program
    {
        static void Main()
        {
            ulong start = ulong.Parse(Console.ReadLine());
            ulong end = ulong.Parse(Console.ReadLine());
            string str =Console.ReadLine();

            BigInteger sum = 0;
            ulong reminder = 0;

            for (ulong i = start; i < end; i++)
            {
                if (i % 5 == 0)
                {
                    sum += i;
                }
                else
                {
                    reminder = i % 5;
                    sum += reminder;
                }
               
            }

            string sumStr = sum.ToString();
            string digitToRepl;

            if (sum % 2 != 0)
            {
                digitToRepl = sumStr[sumStr.Length - 1].ToString();
            }
            else
            {
                digitToRepl = sumStr[0].ToString();
                
            }
            sumStr = sumStr.Replace(digitToRepl,str);
            Console.WriteLine(sumStr);
        }
    }
}
