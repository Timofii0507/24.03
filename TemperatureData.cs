using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._03
{
    public class TemperatureData
    {
        public delegate void TemperatureChangeHandler(float maxDifference);
        public event TemperatureChangeHandler OnMaxDifferenceChanged;

        private DailyTemperature[] temperatures;

        public TemperatureData(int days)
        {
            temperatures = new DailyTemperature[days];
        }

        public void AddTemperature(int day, float max, float min)
        {
            if (day >= 0 && day < temperatures.Length)
            {
                temperatures[day] = new DailyTemperature { Max = max, Min = min };
                CheckMaxDifference();
            }
        }

        private void CheckMaxDifference()
        {
            float maxDifference = 0;
            foreach (var temp in temperatures)
            {
                if (temp != null && temp.Difference > maxDifference)
                {
                    maxDifference = temp.Difference;
                }
            }
            OnMaxDifferenceChanged?.Invoke(maxDifference);
        }
    }
}
