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
            var tester = new NumberTester();
            tester.NumberTested += (number, isOdd) =>
            {
                Console.WriteLine($"Число {number} є " + (isOdd ? "непарним." : "парним."));
            };

            tester.TestNumber(5);
            tester.TestNumber(8);
        }
    }
}
