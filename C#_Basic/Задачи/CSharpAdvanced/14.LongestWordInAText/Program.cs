using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.LongestWordInAText
{
    class Program
    {
        static void Main()
        {
            string[] word = Console.ReadLine().Split(new char[] { ',', ';', ' ', '-', '.' },
        StringSplitOptions.RemoveEmptyEntries);
            string maxWord = word[0];
            for (int i = 0; i < word.Length; i++)
            {
                if (maxWord.Length > word[i].Length)
                {
                    continue;
                }
                else
                {
                    maxWord = word[i];
                }
            }
            Console.WriteLine(maxWord);
        }
    }
}
