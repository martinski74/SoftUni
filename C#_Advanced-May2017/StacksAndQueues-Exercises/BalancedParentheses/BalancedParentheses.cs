using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedParentheses
{
    class BalancedParentheses
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stack = new Stack<char>();
            var openBrackets = new char[] { '{', '[', '(' };
            var isBalanced = true;

            for (int i = 0; i < input.Length; i++)
            {
                var currentBracket = input[i];

                if (openBrackets.Contains(currentBracket))
                {
                    stack.Push(currentBracket);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        isBalanced = false;
                        break;
                    }

                    var lastOpenBracket = stack.Pop();

                    switch (currentBracket)
                    {
                        case '}': if (lastOpenBracket != '{') { isBalanced = false; } break;
                        case ']': if (lastOpenBracket != '[') { isBalanced = false; } break;
                        case ')': if (lastOpenBracket != '(') { isBalanced = false; } break;
                    }

                    if (!isBalanced)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(isBalanced ? "YES" : "NO");
        }
    }
}
