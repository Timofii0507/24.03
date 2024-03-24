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
            NumberTester tester = new NumberTester();

            tester.NumberTested += (number, isEven) =>
            {
                Console.WriteLine($"Число {number} є " + (isEven ? "парним." : "непарним."));
            };

            tester.TestNumber(4);
            tester.TestNumber(7);
        }
    }
}
