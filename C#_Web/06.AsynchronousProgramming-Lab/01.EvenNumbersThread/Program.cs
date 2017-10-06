namespace _01.EvenNumbersThread
{
    using System;
    using System.Threading;

    public class Program
    {
        public static void Main()
        {
            var min = int.Parse(Console.ReadLine());
            var max = int.Parse(Console.ReadLine());

            Thread evens = new Thread(() => PrintEvenNumbes(min,max));
            evens.Start();
            evens.Join();
            Console.WriteLine("Thread finished work");

        }
       
        private static void PrintEvenNumbes(int min, int max)
        {
            for (int i = min; i <= max; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
