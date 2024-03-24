using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._03
{
    public class Program
    {
        public delegate void MaxDistanceEventHandler(object sender, MaxDistanceEventArgs e);

        public static event MaxDistanceEventHandler MaxDistanceEvent;

        public static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            Point3D[] points = {
            new Point3D(0, 0, 0),
            new Point3D(1, 1, 1),
            new Point3D(2, 2, 2),
        };

            MaxDistanceEvent += OnMaxDistance;

            FindMaxDistance(points);
        }

        public static void OnMaxDistance(object sender, MaxDistanceEventArgs e)
        {
            Console.WriteLine($"Максимальна відстань: {e.MaxDistance}");
            Console.WriteLine($"Між точкою A({e.Point1.X}, {e.Point1.Y}, {e.Point1.Z}) та точкою B({e.Point2.X}, {e.Point2.Y}, {e.Point2.Z})");
        }

        public static void FindMaxDistance(Point3D[] points)
        {
            double maxDistance = 0;
            Point3D maxPoint1 = null;
            Point3D maxPoint2 = null;

            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    double distance = Point3D.Distance(points[i], points[j]);
                    if (distance > maxDistance)
                    {
                        maxDistance = distance;
                        maxPoint1 = points[i];
                        maxPoint2 = points[j];
                    }
                }
            }

            MaxDistanceEvent?.Invoke(null, new MaxDistanceEventArgs(maxDistance, maxPoint1, maxPoint2));
        }
    }
}
