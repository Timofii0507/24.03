using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._03
{
    public static class ArrayExtensions
    {
        public static int[] Filter(this int[] array, Predicate<int> predicate)
        {
            List<int> result = new List<int>();
            foreach (var item in array)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result.ToArray();
        }
    }
}
