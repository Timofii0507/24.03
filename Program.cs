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
            string text = "This is a test string for word count extension method.";

            Console.WriteLine($"Initial text: {text}");
            int wordCount = text.WordCount();
            Console.WriteLine($"Word count: {wordCount}");
            WordCounter wordCounter = new WordCounter(text);
            wordCounter.WordCountChanged += WordCounter_WordCountChanged;
            wordCounter.Text = "Updated text with some more words.";

            Console.ReadLine();
        }

        private static void WordCounter_WordCountChanged(int newWordCount)
        {
            Console.WriteLine($"Word count changed: {newWordCount}");
        }
    }
}