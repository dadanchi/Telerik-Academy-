namespace WalkInMatrix
{
    using System;
    using WalkInMatrix.Models;

    class StartUp
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            var matrix = new Matrix(size);
            matrix.Fill();

            Console.WriteLine(matrix);
        }
    }
}
