using System;

class Program
{
    static void Main()
    {
        int numberOfFireFighters = int.Parse(Console.ReadLine());
        string inputLine = Console.ReadLine();

        int savedKids = 0;
        int savedAdults = 0;
        int savedSeniors = 0;

        while (inputLine!="rain")
        {
            int remindingFireFighters = numberOfFireFighters;
            int priorityPersons=1;

            while (remindingFireFighters > 0 && priorityPersons<=3 )
            {
                foreach (char letter in inputLine)
                {
                    if (remindingFireFighters<=0)
                    {
                        break;
                    }
                    switch (priorityPersons)
                    {
                        case 1: 
                            if (letter=='K')
                            {
                                savedKids++;
                                remindingFireFighters--;
                            }
                            break;
                        case 2:
                            if (letter=='A')
                            {
                                savedAdults++;
                                remindingFireFighters--;
                            }
                            break;
                        case 3:
                            if (letter=='S')
                            {
                                savedSeniors++;
                                remindingFireFighters--;
                            }
                            break;
                        
                    }
                }
                priorityPersons++;

            }


            inputLine = Console.ReadLine();
        }
        Console.WriteLine("Kids: {0}",savedKids);
        Console.WriteLine("Adults: {0}",savedAdults);
        Console.WriteLine("Seniors: {0}",savedSeniors);
    }
}

