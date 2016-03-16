using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DetectiveBoev
{
    class Program
    {
        static void Main()
        {
            string secetCode = Console.ReadLine();
            string encriptedMess = Console.ReadLine();
            int assciSum = 0;
            int mask = 0;
            foreach (char symbol in secetCode)
            {
                assciSum += Convert.ToInt32(symbol);
            }

            string str = assciSum.ToString();
            //Console.WriteLine(str);

            while (str.Length > 1)
            {
                int sum = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    sum += int.Parse(str[i].ToString());
                }
                str = sum.ToString();
            }
            char[] arr = encriptedMess.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % int.Parse(str.ToString()) == 0)
                {
                    arr[i] += (char)int.Parse(str.ToString());
                }
                else
                {
                    arr[i] -= (char)int.Parse(str.ToString());
                }

               

            }
            Array.Reverse(arr);

            Console.WriteLine(String.Join("",arr));
        }
    }
}
