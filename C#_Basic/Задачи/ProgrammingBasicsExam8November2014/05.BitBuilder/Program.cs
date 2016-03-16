using System;
using System.Linq;
class Program
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        string binNumber = Convert.ToString(number, 2).PadLeft(32,'0');
       
        
     
        
        while (true)
        {
            string input = Console.ReadLine();

            if (input=="quit")
            {
                break;
            }
            else
            {
                int position = int.Parse(input);
                int bitPosition = (binNumber.Length - 1) - position;
                string order = Console.ReadLine();

                if (order=="flip")
                {
                    char[] binArray = binNumber.ToCharArray();
                 
                    if (binArray[bitPosition]=='1')
                    {
                        binArray[bitPosition]='0';
                    }
                    else
                    {
                        binArray[bitPosition]='1';
                    }
                    binNumber = "";
                    for (int i = 0; i < binArray.Length; i++)
                    {
                        binNumber+=binArray[i];
                    }
                   
                }
                else if (order=="remove")
                {
                    binNumber = binNumber.Remove(bitPosition,1);
                }
                else if (order=="insert")
                {
                    binNumber = binNumber.Insert(bitPosition+1,"1");
                }

            }
           
           
        }
        long result = Convert.ToInt64(binNumber, 2);
        Console.WriteLine(result);

    }
}

