using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._03
{
    public class Program
    {
        public delegate void FibonacciTestHandler(int number, bool isFibonacci);

        public static event FibonacciTestHandler OnFibonacciTest;

        public static void Main()
        { 
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            OnFibonacciTest += (number, isFibonacci) =>
            {
                Console.WriteLine($"{number} є числом Фібоначчі: {isFibonacci}");
            };

            TestFibonacci(21);
            TestFibonacci(4);
        }

        public static void TestFibonacci(int number)
        {
            bool isFibonacci = number.IsFibonacci();
            OnFibonacciTest?.Invoke(number, isFibonacci);
        }
    }
}