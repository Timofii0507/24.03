using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._03
{
    class Program
    {
        public static event Action<string> OnVowelCounting;

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            OnVowelCounting += (s) => Console.WriteLine($"Кількість голосних у рядку: {s.CountVowels()}");

            string testString = "Привіт, як справи?";
            OnVowelCounting?.Invoke(testString);
        }
    }
}
