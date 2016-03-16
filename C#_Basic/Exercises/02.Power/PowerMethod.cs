using System;
//Write a method Power() that calculates the power of a given number.
//•	The method should receive a number and the power as arguments
//•	The method should return double as result 
//The input should be read from the console.

class PowerMethod
{
    static void Main()
    {
        Console.Write("Enter number: ");
        double n = double.Parse(Console.ReadLine());
        Console.Write("Enter power: ");
        int p = int.Parse(Console.ReadLine());
        double result = Power(n, p,true);//or false
        Console.WriteLine(result);
        
    }
    static double Power(double num, int pow) 
    {
        double result = 1;
        for (int i = 0; i < pow; i++)
        {
            result = result * num;
        }
        return result;
    }
    //Write an overload method with the same name that receives an additional argument -
    //boolean value roundDown. If roundDown is true, the result should be rounded
    //down to the nearest integer. Otherwise, return the original result. 
    static double Power(double num, int pow,bool roundDown)
    {
        double result = Power(num,pow);
        if (roundDown)
        {
            result = (int)result;
        }
        return result;
    }
}

