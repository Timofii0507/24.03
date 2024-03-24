using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._03
{
    public static class StringExtensions
    {
        public static event EventHandler<SentenceCountedEventArgs> SentenceCounted;

        public static int CountSentences(this string str)
        {
            int count = str.Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).Length;
            SentenceCounted?.Invoke(null, new SentenceCountedEventArgs(count));
            return count;
        }
    }
}
