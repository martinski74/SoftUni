using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        input = input.ToUpper();
        int letSum = 0;
        int firstSum = 1;
        int secondSum = 1;
        int count = 0;

        for (int i = 0; i < input.Length; i++)
        {
            letSum += input[i] - 'A' + 1;
        }

        for (int d1 = 0; d1 <= 9; d1++)
        {
            for (int d2 = 0; d2 <= 9; d2++)
            {
                for (int d3 = 0; d3 <= 9; d3++)
                {
                    for (int d4 = 0; d4 <= 9; d4++)
                    {
                        for (int d5 = 0; d5 <= 9; d5++)
                        {
                            for (int d6 = 0; d6 <= 9; d6++)
                            {
                                firstSum = d1 * d2 * d3;
                                secondSum = d4 * d5 * d6;
                                if (firstSum == secondSum && firstSum == letSum)
                                {
                                    Console.WriteLine("{0}{1}{2}-{3}{4}{5}",d1,d2,d3,d4,d5,d6);
                                    count++;
                                }
                            }
                        }
                    }
                }
            }
        }
        if (count==0)
        {
            Console.WriteLine("No");
        }


    }
}

