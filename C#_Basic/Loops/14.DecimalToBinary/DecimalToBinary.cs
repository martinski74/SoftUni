using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        int number = int.Parse(Console.ReadLine());

        int reminder;
        string result = string.Empty;

        while (number > 0)
        {
            reminder = number % 2;
            number = number / 2;
            result = reminder.ToString() + result;
        }
        Console.WriteLine(result);
    }
}

