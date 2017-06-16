using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.TriFunction
{
    class TriFunction
    {
        static void Main(string[] args)
        {
            var targetCharactersSum = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split();

            Func<string, int, bool> isValidWord = (str, num) => str.ToCharArray()
                                                                    .Select(ch => (int)ch).Sum() >= num;

            Func<string[], int, Func<string, int, bool>, string> firstValidName = (arr, num, func) => arr
                .FirstOrDefault(str => func(str, num));

            var result = firstValidName(names, targetCharactersSum, isValidWord);
            Console.WriteLine(result);
        }
    }
}
