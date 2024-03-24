using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._03
{
    public delegate void NumberTestedEventHandler(int number, bool isOdd);

    public class NumberTester
    {
        public event NumberTestedEventHandler NumberTested;

        public void TestNumber(int number)
        {
            bool isOdd = number.IsOdd();
            OnNumberTested(number, isOdd);
        }

        protected virtual void OnNumberTested(int number, bool isOdd)
        {
            NumberTested?.Invoke(number, isOdd);
        }
    }
}
