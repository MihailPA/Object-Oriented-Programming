using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems1_4_3DPoints
{
    public static class Distance
    {
        public static double CalculateDistance(Point3D first, Point3D second)
        {
            double equationOne = (second.X - first.X) * (second.X - first.X);
            double equationTwo = (second.Y - first.Y) * (second.Y - first.Y);
            double equationThree = (second.Z - first.Z) * (second.Z - first.Z);

            double distance = Math.Sqrt(equationOne + equationTwo + equationThree);

            return distance;
        }
    }
}
