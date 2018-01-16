using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LongestSubSequences
{
    public class LongestSubSequences
    {
        public static void Main()
        {
            

            FindLongestSubsequense();


             void FindLongestSubsequense()
            {

                List<int> numbers = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse).ToList();

                List<int> newlist = new List<int>();
                int maxnumbers = 0;
                int count = 1;
                int maxcount = 1;
                int pos = 0;

                while (pos < numbers.Count - 1)
                {

                    if (numbers[pos] == numbers[pos + 1])
                    {
                        count++;

                        if (count > maxcount)
                        {
                            maxcount = count;
                            maxnumbers = numbers[pos];
                        }

                    }
                    else
                    {
                        count = 1;
                    }
                    pos++;
                    if (maxcount == 1)
                    {
                        maxnumbers = numbers[0];
                    }
                }
                for (int i = 0; i < maxcount; i++)
                {
                    newlist.Add(maxnumbers);
                }
                Console.WriteLine(string.Join(" ", newlist));
            }
        }
    }
}

