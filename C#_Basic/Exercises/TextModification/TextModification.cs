using System;
//You are given a string. Go through all letters and if the letter's ASCII
//code divides by 3 without remainder, raise the letter to upper case.
class TextModification
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[]letters= input.ToCharArray();

        for (int i = 0; i < letters.Length; i++)
        {
            if (letters[i]%3==0)
            {
                letters[i]=Char.ToUpper(letters[i]);
            }
        }
        foreach (var leter in letters)
        {
            Console.Write(leter);
        }
        Console.WriteLine();

    }
}

