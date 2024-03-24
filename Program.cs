using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._03
{
    public static class StringExtensions
    {
        public static int CountUkrainianConsonants(this string input)
        {
            return input.Count(c => "бвгґджзйклмнпрстфхцчшщ".Contains(Char.ToLower(c)));
        }
    }

    public class Program
    {
        public static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            Action<string> onConsonantsCounted = (s) => Console.WriteLine($"У рядку '{s}' {s.CountUkrainianConsonants()} українських приголосних.");

            string testString = "Привіт, Світ!";
            onConsonantsCounted(testString);
        }
    }
}
