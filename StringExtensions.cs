using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._03
{
    public static class StringExtensions
    {
        public static int CountVowels(this string inputString)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y', 'а', 'е', 'є', 'и', 'і', 'ї', 'о', 'у', 'ю', 'я' };
            return inputString.Count(c => vowels.Contains(Char.ToLower(c)));
        }
    }
}
