using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        char diagonal = char.Parse(Console.ReadLine());
        StringBuilder assciMesage = new StringBuilder();

        foreach (var symbol in input)
        {
            assciMesage.Append(symbol % 10);
        }
        StringBuilder encripted = new StringBuilder();

        for (int i = 0; i < assciMesage.Length; i++)
        {
            int currDigit;
            currDigit = int.Parse(assciMesage[i].ToString());

            if (currDigit == 0 || currDigit % 2 == 0) //even
            {
                currDigit = currDigit * currDigit;
            }
            else//odd
            {
                int leftDigit = 0;
                int rightDigit = 0;
                if ((i - 1) < 0)
                {
                    leftDigit = 0;
                }
                else
                {
                    leftDigit = int.Parse(assciMesage[i-1].ToString());
                }
                if ((i+1)==assciMesage.Length)
                {
                    rightDigit = 0;
                }
                else
                {
                    rightDigit = int.Parse(assciMesage[i+1].ToString());
                }
                currDigit += leftDigit + rightDigit;
            }
            encripted.Append(currDigit);

        }

        int matrix =encripted.Length;

        if (diagonal =='\\')
        {
            for (int i = 0; i < matrix; i++)
            {
                for (int j = 0; j < matrix; j++)
                {
                    if (i==j)
                    {
                        Console.Write(encripted[i]+" ");
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }
                Console.WriteLine();
            }
        }
        else
        {
            for (int i = 0; i < matrix; i++)
            {
                for (int j = 0; j < matrix; j++)
                {
                    if (j==matrix-1-i)
                    {
                        Console.Write(encripted[matrix-1-i]+" ");
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

