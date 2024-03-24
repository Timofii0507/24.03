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
            Fraction[] fractions = {
            new Fraction(1, 2),
            new Fraction(3, 4),
            new Fraction(1, 3),
            new Fraction(5, 8)
        };

            Fraction minFraction = fractions.MinFraction();
            Fraction maxFraction = fractions.MaxFraction();

            Console.WriteLine("Мінімальний дріб: " + minFraction.Numerator + "/" + minFraction.Denominator);
            Console.WriteLine("Максимальний дріб: " + maxFraction.Numerator + "/" + maxFraction.Denominator);
        }
    }
}