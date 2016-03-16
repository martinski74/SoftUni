using System;

class MultiplicationSign
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double result = a * b * c;
        if (result > 0)
        {
            Console.WriteLine("+");
        }
        else if (result == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            Console.WriteLine("-");
        }
    }
}

