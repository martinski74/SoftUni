﻿using System;

namespace _01.GenericBox
{
   public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var inputString = Console.ReadLine();
                var box = new Box<string>(inputString);
                Console.WriteLine(box);
            }
        }
    }
}
