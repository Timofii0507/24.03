using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            StringExtensions.OnLastWordLengthCalculated += LastWordLengthCalculatedEventHandler;

            string testString = "Привіт, Світ!";
            int lastWordLength = testString.LastWordLength();
            Console.WriteLine($"Довжина останнього слова: {lastWordLength}");
        }

        static void LastWordLengthCalculatedEventHandler(int length)
        {
            Console.WriteLine($"Підрахунок довжини останнього слова завершено. Довжина: {length}");
        }
    }
}