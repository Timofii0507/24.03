using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._03
{
    class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            StringExtensions.SentenceCounted += OnSentenceCounted;

            string text = "Це тестовий рядок. Він містить кілька речень! Чи працює метод?";
            int sentenceCount = text.CountSentences();
            Console.WriteLine($"Кількість речень у рядку: {sentenceCount}");
        }

        private static void OnSentenceCounted(object sender, SentenceCountedEventArgs e)
        {
            Console.WriteLine($"Підрахунок завершено. Кількість речень: {e.Count}");
        }
    }
}
