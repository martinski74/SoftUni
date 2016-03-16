using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyRepairs
{
    class Program
    {
        static void Main()
        {
            uint number = uint.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(number, 2));
            int repKits = int.Parse(Console.ReadLine());
            int atacks = int.Parse(Console.ReadLine());
            for (int i = 0; i < atacks; i++)
            {
                int atakcedBit = int.Parse(Console.ReadLine());
                int mask = ~(1 << atakcedBit);
                number = number & (uint)mask;
            }
            string strNumber = Convert.ToString(number, 2).PadLeft(64, '0');
            char[] arr = strNumber.ToCharArray();
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                char curr =arr[i] ;
                if (curr ==0 && (curr+1)==0)
                {
                    curr = '1';
                }
            }



           

        }
    }
}
