using System;

class Program
{
    static void Main()
    {
        long numberOfCabins = long.Parse(Console.ReadLine());
        string nextCommand = Console.ReadLine();
        long currentPosition = 0;
        long totalLengthCovered=0;
        while (nextCommand != "Found a free one!")
        {
            long stepsCuont = long.Parse(nextCommand);
            long oldPosition = currentPosition;
            currentPosition = (currentPosition + stepsCuont) % numberOfCabins;
            long difference = currentPosition - oldPosition;

            if (difference > 0)
            {
                Console.WriteLine("Go {0} steps to the right, Ani.", Math.Abs(difference));
              
            }
            else if (difference < 0)
            {
                Console.WriteLine("Go {0} steps to the left, Ani.", Math.Abs(difference));
               
            }
            else
            {
                Console.WriteLine("Stay there, Ani.");
               
            }
            totalLengthCovered += Math.Abs(difference);
            nextCommand = Console.ReadLine();
        }
        
        Console.WriteLine("Moved a total of {0} steps.", totalLengthCovered);


    }
}

