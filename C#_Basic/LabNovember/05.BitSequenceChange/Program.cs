using System;

class Program
{
    static void Main()
    {
        string input = Convert.ToString(long.Parse(Console.ReadLine()), 2).PadLeft(64, '0');
        int[] arrNumb = new int[64];

        for (int i = 0; i < 64; i++) //filling array 
        {
            arrNumb[i] = input[63 - i] - '0';
        }
        for (int i = 0; i < 3; i++)
        {
            if (arrNumb[3+i]!=arrNumb[24+i])
            {
                int temp = arrNumb[3 + i];
                arrNumb[3+i]=arrNumb[24+i];
                arrNumb[24 + i] = temp;
            }
        }
        string result = "";
        for (int i = 63; i >= 0; i--)
        {
            result += arrNumb[i];
        }
        Console.WriteLine(Convert.ToInt64(result,2));
    }
}

