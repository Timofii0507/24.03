using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._03
{
    public static class StringExtensions
    {
        public static int WordCount(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return 0;

            int wordCount = 0;
            bool inWord = false;

            foreach (char c in str)
            {
                if (char.IsWhiteSpace(c))
                {
                    if (inWord)
                    {
                        wordCount++;
                        inWord = false;
                    }
                }
                else
                {
                    inWord = true;
                }
            }

            if (inWord)
                wordCount++;

            return wordCount;
        }
    }
}
