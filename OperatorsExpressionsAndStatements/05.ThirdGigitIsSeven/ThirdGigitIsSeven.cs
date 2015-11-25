using System;
//Write an expression that checks for given integer if its third digit from right-to-left is 
class ThirdGigitIsSeven
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int thirdDig = (n / 100)%10;
        bool result =thirdDig==7;
        Console.WriteLine(result);
    }
}

