using System;

namespace Calculateur_de_distances
{
    class Dimensions
    {
        public static double OneD(double x1, double x2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2));
        }

        public static double TwoD(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public static double ThreeD(double x1, double x2, double y1, double y2, double z1, double z2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
        }

        public static double FourD(double x1, double x2, double y1, double y2, double z1, double z2, double v1, double v2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) + Math.Pow(v2 - v1, 2));
        }
    }
}
