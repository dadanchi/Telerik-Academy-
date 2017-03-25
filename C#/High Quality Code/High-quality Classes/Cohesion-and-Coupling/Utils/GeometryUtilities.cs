namespace CohesionAndCoupling.Utils
{
    using System;

    public static class GeometryUtilities
    {
        public static double CalcDistanceBetweenPoints(double[] p1, double[] p2)
        {
            if (p1.Length != p2.Length)
            {
                throw new ArgumentException("Points must be in the same dimension");
            }

            if (p1 == null || p2 == null)
            {
                throw new ArgumentException("Points cannot be null");
            }

            double distance = 0;

            for (int i = 0; i < p1.Length; i++)
            {
                double firstPointCoordinate = p1[i];
                double secondPointCoordinate = p2[i];

                distance += Math.Sqrt((secondPointCoordinate - firstPointCoordinate) *
                    (secondPointCoordinate - firstPointCoordinate));
            }

            return distance;
        }
    }
}
