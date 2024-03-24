using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._03
{
    public static class StringExtensions
    {
        public delegate void LastWordLengthCalculated(int length);

        public static event LastWordLengthCalculated OnLastWordLengthCalculated;

        public static int LastWordLength(this string str)
        {
            str = str.TrimEnd();

            int length = 0;
            bool foundNonSpace = false;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (char.IsWhiteSpace(str[i]))
                {
                    if (foundNonSpace)
                        break;
                }
                else
                {
                    foundNonSpace = true;
                    length++;
                }
            }

            OnLastWordLengthCalculated?.Invoke(length);

            return length;
        }
    }
}
