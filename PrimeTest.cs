using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._03
{
    public class PrimeTest
    {
        public delegate void PrimeCheckedHandler(int number, bool isPrime);

        public event PrimeCheckedHandler PrimeChecked;

        protected virtual void OnPrimeChecked(int number, bool isPrime)
        {
            PrimeChecked?.Invoke(number, isPrime);
        }

        public void CheckNumber(int number)
        {
            bool result = number.IsPrime();
            OnPrimeChecked(number, result);
        }
    }
}
