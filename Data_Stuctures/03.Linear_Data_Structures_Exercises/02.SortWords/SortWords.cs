namespace _02.SortWords
{
    using System;
    using System.Collections.Generic;

    public class SortWords
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            var result = new List<string>(input);
            result.Sort();

            Console.WriteLine(string.Join(" ", result));

            //foreach (var item in result)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

        }
    }
}
