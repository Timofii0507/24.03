using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._03
{
    public class Program
    {
        public static event Action<string, bool> OnValidationComplete;

        public static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            OnValidationComplete += (s, b) => Console.WriteLine($"'{s}' is " + (b ? "valid" : "invalid"));

            Test("(){}[]");
            Test("(())");
            Test("[{}]");
            Test("[}");
            Test("[[{]}]");
        }

        public static void Test(string input)
        {
            bool isValid = input.IsValidParentheses();
            OnValidationComplete?.Invoke(input, isValid);
        }
    }
}