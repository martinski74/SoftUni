using System;

class PrintTheASCIITable
{
    static void Main()
    {
        //Console.OutputEncoding = System.Text.Encoding.UTF8;
        for (int i = 0; i < 255; i++)
        {
            Console.Write((char)i+" ");
        }
        Console.WriteLine();
    }
}

