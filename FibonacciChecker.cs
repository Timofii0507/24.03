using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._03
{
    public static class FibonacciChecker
    {
        public static bool IsFibonacci(this int number)
        {
            int a = 0;
            int b = 1;
            while (a < number)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a == number;
        }
    }
}
