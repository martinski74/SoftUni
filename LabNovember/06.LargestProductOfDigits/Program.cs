using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.LargestProductOfDigits
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int maxProduct = 0;
            int cuurProduct = 0;
            int[] arr = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                arr[i] = int.Parse(input[i].ToString());//filling array
            }
            for (int i = 0; i < input.Length - 5; i++)
            {
                cuurProduct = arr[i] * arr[i + 1] * arr[i + 2] * arr[i + 3] * arr[i + 4] * arr[i + 5]; 
                if (cuurProduct > maxProduct)
                {
                    maxProduct = cuurProduct;       //check the biggest product
                }

            }
            Console.WriteLine(maxProduct);
        }
    }
}
