using System;

class Program
{
    static void Main()
    {
        string type = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        double result = 0;
        switch (type)
        {
            case "Premiere": result = rows * cols * 12.00;
                break;
            case "Normal": result = rows * cols * 7.50;
                break;
            case "Discount": result = rows * cols * 5.00;
                break;
        }
        Console.WriteLine("{0:0.00} leva", result);
    }
}

