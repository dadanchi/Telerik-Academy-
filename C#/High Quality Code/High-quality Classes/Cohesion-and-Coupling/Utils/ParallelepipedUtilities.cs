namespace CohesionAndCoupling.Utils
{
    using System;

    public static class ParallelepipedUtilities
    {
        public static double CalcVolume(double width, double height, double depth)
        {
            double volume = width * height * depth;

            return volume;
        }

        public static double CalcDiagonalLength(double[] sides)
        {
            if (sides == null)
            {
                throw new ArgumentException("Sides cannot be null");
            }

            int length = sides.Length;

            double[] zeroPoint = new double[length];
            double[] endPoint = new double[length];

            for (int i = 0; i < length; i++)
            {
                zeroPoint[i] = 0;
                endPoint[i] = sides[i];
            }

            double distance = GeometryUtilities.CalcDistanceBetweenPoints(zeroPoint, endPoint);

            return distance;
        }
    }
}
