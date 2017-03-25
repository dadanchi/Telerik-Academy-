namespace CohesionAndCoupling
{
    using System;

    using CohesionAndCoupling.Utils;

    public class UtilsExamples
    {
        public static void Main()
        {
            // File utilities check
            Console.WriteLine(FileUtilities.GetFileExtension("example"));
            Console.WriteLine(FileUtilities.GetFileExtension("example.pdf"));
            Console.WriteLine(FileUtilities.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileUtilities.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileUtilities.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileUtilities.GetFileNameWithoutExtension("example.new.pdf"));

            // Geometry check
            double[] pointA = { 1, -2 };
            double[] pointB = { 3, 4 };

            var distance2D = GeometryUtilities.CalcDistanceBetweenPoints(pointA, pointB);
            Console.WriteLine("Distance in the 2D space = {0:f2}", distance2D);

            double[] pointC = { -6, 4, -5 };
            double[] pointD = { 3, 6, 2 };

            var distance3D = GeometryUtilities.CalcDistanceBetweenPoints(pointC, pointD);
            Console.WriteLine("Distance in the 3D space = {0:f2}", distance3D);

            // Parallelepiped check
            double width = 3;
            double height = 4;
            double depth = 5;

            var volume = ParallelepipedUtilities.CalcVolume(width, height, depth);
            var diagonalXYZ = ParallelepipedUtilities.CalcDiagonalLength(new double[] { width, height, depth });
            var diagonalXY = ParallelepipedUtilities.CalcDiagonalLength(new double[] { width, height });
            var diagonalXZ = ParallelepipedUtilities.CalcDiagonalLength(new double[] { width, depth });
            var diagonalYZ = ParallelepipedUtilities.CalcDiagonalLength(new double[] { height, depth });

            Console.WriteLine("Volume = {0:f2}", volume);
            Console.WriteLine("Diagonal XYZ = {0:f2}", diagonalXYZ);
            Console.WriteLine("Diagonal XY = {0:f2}", diagonalXY);
            Console.WriteLine("Diagonal XZ = {0:f2}", diagonalXZ);
            Console.WriteLine("Diagonal YZ = {0:f2}", diagonalYZ);
        }
    }
}
