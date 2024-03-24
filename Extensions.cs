using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._03
{
    public static class Extensions
    {
        public static double AverageAge(this Person[] people)
        {
            return people.Average(p => p.Age);
        }
    }
}
