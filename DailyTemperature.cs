using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._03
{
    public class DailyTemperature
    {
        public float Max { get; set; }
        public float Min { get; set; }
        public float Difference => Max - Min;
    }
}
