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
            PrimeTest primeTest = new PrimeTest();
            
            primeTest.PrimeChecked += (number, isPrime) =>
            {
                Console.WriteLine($"{number} є простим числом: {isPrime}");
            };

            primeTest.CheckNumber(11);
            primeTest.CheckNumber(4);  
        }
    }
}
