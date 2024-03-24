using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._03
{
    public delegate void NumberTestedEventHandler(int number, bool isEven);

    public class NumberTester
    {
        public event NumberTestedEventHandler NumberTested;

        public void TestNumber(int number)
        {
            bool isEven = number.IsEven();
            NumberTested?.Invoke(number, isEven);
        }
    }
}
