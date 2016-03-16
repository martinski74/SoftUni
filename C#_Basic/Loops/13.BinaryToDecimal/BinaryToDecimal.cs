using System;
using System.Numerics;

class BinaryToDecimal
{
    static void Main()
    {
        
        Console.Write("Enter binary number: ");
        BigInteger binary = BigInteger.Parse(Console.ReadLine());
  
        BigInteger result = 0;
   
        int strn = binary.ToString().Length; //how many digits has my number

        for (int i = 0; i < strn; i++)
        {
            BigInteger lastDigit = binary % 10; // get the last digit
            result+= lastDigit * (int)(Math.Pow(2, i));
            binary = binary / 10; //remove the last digit
        }
        Console.WriteLine(result);

    }

}

