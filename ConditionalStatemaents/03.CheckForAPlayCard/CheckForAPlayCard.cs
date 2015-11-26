using System;

class CheckForAPlayCard
{
    static void Main()
    {
        string card = Console.ReadLine();
        string[] cardArr = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        bool isIn = false;
        for (int i = 0; i < cardArr.Length; i++)
        {
            if (card==cardArr[i])
            {
                isIn=true;
                break;
            }
            else
            {
                isIn = false;
            }
        }
        if (isIn)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
       

    }
}

