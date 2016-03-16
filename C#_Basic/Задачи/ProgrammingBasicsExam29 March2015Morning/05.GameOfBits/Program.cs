using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        string command = Console.ReadLine();

        List<char> newNumber = Convert.ToString(number,2).ToList();
        while (command!="Game Over!")
        {
            if (command=="Odd")
            {
                for (int i = newNumber.Count-2; i >= 0; i-=2)
                {
                    newNumber.RemoveAt(i);
                }
            }
            else
            {
                for (int i = newNumber.Count - 1; i >= 0; i -= 2)
                {
                    newNumber.RemoveAt(i);
                }    
            }
            command = Console.ReadLine();
        }
        string result = "";
        int count = 0;
      
        foreach (var bit in newNumber)
        {
            if (bit=='1')
            {
                count++;
            }
            result += bit;
          
        }
        if (number==0 || number==1)
        {
            result = "0";
            Console.WriteLine("{0} -> {1}", result, count);
        }
        else
        {
            Console.WriteLine("{0} -> {1}", Convert.ToInt64(result, 2), count);
        }
        
       
    }
}

