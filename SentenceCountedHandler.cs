using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._03
{
    public class SentenceCountedEventArgs : EventArgs
    {
        public int Count { get; }

        public SentenceCountedEventArgs(int count)
        {
            Count = count;
        }
    }
}
