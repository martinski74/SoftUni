using System;

class Program
{
    static int CountOnes(int number)
    {
        int result = 0;
        while (number != 0)
        {
            number = number & (number - 1);
            result++;
        }
        return result;
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

       
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());

        }

        int mid = 0;
        int left = 0;
        int rigth = 0;

        for (int i = 0; i < n - 1; i++)
        {
            int num1 = numbers[i];
            int num2 = numbers[i + 1];

            int vertical = num1 & num2;
            mid += CountOnes(vertical);
            int leftBits = num1 & (num2 << 1);
            left += CountOnes(leftBits);
            int rigthBits = (num1 << 1) & num2;
            rigth += CountOnes(rigthBits);

        }
        Console.WriteLine(left);
        Console.WriteLine(rigth);
        Console.WriteLine(mid);

    }


}

