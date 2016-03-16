using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int totalLenght = 0;
        int joins = 0;
        for (int i = 0; i < n; i++)
        {
            int lenght = int.Parse(Console.ReadLine());
            string measure = Console.ReadLine();

            if (measure == "meters")
            {
                lenght *= 100;
            }
           
            if (lenght >= 20)
            {
                totalLenght += lenght;
                joins++;
            }
        }
        totalLenght = totalLenght - (joins - 1) * 3;
        int numberOfCabels = totalLenght / 504;
        int remindCabels = totalLenght % 504;
        Console.WriteLine(numberOfCabels);
        Console.WriteLine(remindCabels);
    }
}

