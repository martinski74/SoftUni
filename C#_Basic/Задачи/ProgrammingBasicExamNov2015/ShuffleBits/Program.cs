using System;

class Program
{
    static void Main()
    {
        uint n1 = uint.Parse(Console.ReadLine());
        //Console.WriteLine(Convert.ToString(n1,2).PadLeft(32,'0'));
        string arr1 = Convert.ToString(n1, 2).PadLeft(32, '0');

        uint n2 = uint.Parse(Console.ReadLine());
        //Console.WriteLine(Convert.ToString(n2, 2).PadLeft(32, '0'));
        string arr2 = Convert.ToString(n2, 2).PadLeft(32, '0');
        string result = "";

        if (n1 >= n2)
        {
            for (int i = 0; i < 32; i++)
            {
                result += arr1[i].ToString() + arr2[i].ToString();

            }
        }
        else
        {
            for (int i = 0; i < 31; i +=2)
            {
                result += (arr1[i].ToString() + arr1[i + 1].ToString()) + (arr2[i].ToString() + arr2[i + 1].ToString());

            }
        }

        //Console.WriteLine(result);
        Console.WriteLine(Convert.ToUInt64(result,2));

    }
}

