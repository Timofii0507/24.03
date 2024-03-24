using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._03
{
    public class MaxDistanceEventArgs : EventArgs
    {
        public double MaxDistance { get; set; }
        public Point3D Point1 { get; set; }
        public Point3D Point2 { get; set; }

        public MaxDistanceEventArgs(double maxDistance, Point3D point1, Point3D point2)
        {
            MaxDistance = maxDistance;
            Point1 = point1;
            Point2 = point2;
        }
    }
}
