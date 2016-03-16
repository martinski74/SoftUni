using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        int columns = Int32.Parse(Console.ReadLine());
        string[] bombs = Console.ReadLine().Split(' ');
        int rows = (int)Math.Ceiling((double)text.Length / columns);
        char[] bombedArray = text.ToCharArray();
        for (int i = 0; i < bombs.Length; i++)
        {
            bool chk = true;
            int bomb = Int32.Parse(bombs[i]);
            do
            {
                if (bombedArray[bomb] == ' ' && chk)
                {
                    bomb += columns;
                    chk = true;
                }
                else
                {
                    chk = false;
                    if (bombedArray[bomb] == ' ')
                    {
                        break;
                    }
                    else
                    {
                        bombedArray[bomb] = ' ';
                        bomb += columns;
                    }
                }
            } while (bomb < text.Length);
        }
        StringBuilder resultAfterBombing = new StringBuilder();
        foreach (char value in bombedArray)
        {
            resultAfterBombing.Append(value);
        }
        Console.WriteLine(resultAfterBombing.ToString());
    }
}

