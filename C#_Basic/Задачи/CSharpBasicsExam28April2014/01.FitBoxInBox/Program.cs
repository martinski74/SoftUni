using System;

class Program
{
    static void Main()
    {
        int w1 = int.Parse(Console.ReadLine());
        int h1 = int.Parse(Console.ReadLine());
        int d1 = int.Parse(Console.ReadLine());

        int w2 = int.Parse(Console.ReadLine());
        int h2 = int.Parse(Console.ReadLine());
        int d2 = int.Parse(Console.ReadLine());
        //check first box fit to second
        ChckBoxes(w1, h1, d1, w2, h2, d2);
        ChckBoxes(w1, h1, d1, w2, d2, h2);
        ChckBoxes(w1, h1, d1, h2, w2, d2);
        ChckBoxes(w1, h1, d1, h2, d2, w2);
        ChckBoxes(w1, h1, d1, d2, w2, h2);
        ChckBoxes(w1, h1, d1, d2, h2, w2);
        //check second box fit to first
        ChckBoxes(w2, h2, d2, w1, h1, d1);
        ChckBoxes(w2, h2, d2, w1, d1, h1);
        ChckBoxes(w2, h2, d2, h1, w1, d1);
        ChckBoxes(w2, h2, d2, h1, d1, w1);
        ChckBoxes(w2, h2, d2, d1, w1, h1);
        ChckBoxes(w2, h2, d2, d1, h1, w1);

    }

    private static void ChckBoxes(int firstWidth, int firstHeight, int firsDept,
        int secondWidth, int secondHeight, int secondDept)
    {
        if (firstWidth < secondWidth && firstHeight < secondHeight && firsDept < secondDept)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})",firstWidth,firstHeight,firsDept,
                secondWidth,secondHeight,secondDept);
        }
    }
}

