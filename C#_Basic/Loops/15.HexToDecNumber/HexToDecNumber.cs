using System;


class HexToDecNumber
{
    static void Main()
    {
        string hexNumber = Console.ReadLine();
        long decNumber = 0;
        long power = 1;
        for (int i = hexNumber.Length - 1; i >= 0; i--)
        {
            int num;
            switch (hexNumber[i])
            {
                case 'A': num = 10; break;
                case 'B': num = 11; break;
                case 'C': num = 12; break;
                case 'D': num = 13; break;
                case 'E': num = 14; break;
                case 'F': num = 15; break;
                default: num = (int)hexNumber[i] - 48; break;
            }
            decNumber += num * power;
            power *= 16;
        }
        Console.WriteLine(decNumber);
    }
}

