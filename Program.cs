using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._03
{
    class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            var temperatureData = new TemperatureData(7); 

            temperatureData.OnMaxDifferenceChanged += (maxDifference) =>
            {
                Console.WriteLine($"Максимальна різниця температур: {maxDifference}°C");
            };

            temperatureData.AddTemperature(0, 25.5f, 15.3f);
            temperatureData.AddTemperature(1, 22.8f, 14.4f);
        }
    }

}