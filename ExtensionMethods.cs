using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._03
{
    public static class ExtensionMethods
    {
        public static bool IsValidParentheses(this string input)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in input)
            {
                switch (c)
                {
                    case '{':
                    case '(':
                    case '[':
                        stack.Push(c);
                        break;
                    case '}':
                        if (stack.Count == 0 || stack.Pop() != '{') return false;
                        break;
                    case ')':
                        if (stack.Count == 0 || stack.Pop() != '(') return false;
                        break;
                    case ']':
                        if (stack.Count == 0 || stack.Pop() != '[') return false;
                        break;
                }
            }
            return stack.Count == 0;
        }
    }
}
