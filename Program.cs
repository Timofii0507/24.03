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
            int[] array = { 1, 2, 3, 4, 5, 6 };

            int[] evenNumbers = array.Filter(x => x % 2 == 0);
            Console.WriteLine("Парні числа: " + string.Join(", ", evenNumbers));

            int[] oddNumbers = array.Filter(x => x % 2 != 0);
            Console.WriteLine("Непарні числа: " + string.Join(", ", oddNumbers));
        }
    }
}