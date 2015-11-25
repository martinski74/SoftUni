using System;
//Write a Boolean expression that checks for given integer if it can be divided 
//(without remainder) by 7 and 5 in the same time. Examples:
class DivideBySevenAndFive
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool divisible=(n%7==0)&&(n%5==0);

        if (n==0)
        {
            divisible = false;  
        }
            Console.WriteLine(divisible);
        
       
    }
}

