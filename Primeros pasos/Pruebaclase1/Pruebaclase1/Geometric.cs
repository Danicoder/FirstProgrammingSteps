using System;
using System.Collections.Generic;
using System.Text;

namespace Pruebaclase1
{
    class Geometric
    {
        public static double CalculateVectorLegth(double vx, double vy)
        {
            double aux = vx * vx + vy * vy;
            return System.Math.Sqrt(aux);
        }

        public static double CalculateVector3DLegth(double vx, double vy, double vz)
        {
            double aux = vx * vx + vy * vy + vz * vz;
            return System.Math.Sqrt(aux);
        }

        public static double CalculateDistance2D(double x1, double x2, double y2, double y1)
        {
            double vx = x2 - x1;
            double vy = y2 - y1;
            return CalculateVectorLegth(vx, vy);
        }
        public static double GetCircleArea(double r)
        {
            double aux, Area;
            aux = r * r;
            Area = System.Math.PI * aux;
            return Area;
        }
    }
}
