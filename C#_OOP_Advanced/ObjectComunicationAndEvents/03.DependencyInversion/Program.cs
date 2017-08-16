using System;

namespace _03.DependencyInversion
{
    public class Program
    {
        public static void Main()
        {
            PrimitiveCalculator calc = new PrimitiveCalculator();

            string[] input = Console.ReadLine().Split();
            while (input[0] != "End")
            {
                if (input[0]=="mode")
                {
                    calc.ChangeStrategy(char.Parse(input[1]));
                }
                else
                {
                    Console.WriteLine(calc.PerformCalculation(int.Parse(input[0]),int.Parse(input[1])));
                }
                input = Console.ReadLine().Split();
            }
        }
    }
}
