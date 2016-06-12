using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLettersInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            int[]counts= new int[text.Max()+1];


            for (int i = 0; i < text.Length; i++)
            {
                counts[text[i]]++;
            }
            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] > 0)
                {
                    Console.WriteLine("{0} -> {1}",(char)i,counts[i]);
                }
            }
        }
    }
}
