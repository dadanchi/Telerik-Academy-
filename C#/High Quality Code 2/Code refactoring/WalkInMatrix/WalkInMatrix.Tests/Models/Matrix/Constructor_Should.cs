namespace WalkInMatrix.Tests.Models.Matrix
{
    using System;

    using NUnit.Framework;
    using WalkInMatrix.Models;

    [TestFixture]
    public class Constructor_Should
    {
        [TestCase(-1)]
        [TestCase(200)]
        public void ThrowArgumentException_WhenInvalidSizeValueIsSet(int size)
        {
            Assert.Throws<ArgumentException>(() => new Matrix(size));
        }

        [TestCase(1)]
        [TestCase(10)]

        public void SetSize_WhenProperValueIsGiven(int size)
        {
            var matrix = new Matrix(size);

            Assert.AreEqual(size, matrix.Size);
        }

        public void ReturnInstanceOfMatrix_WhenValidValuesArePassed()
        {
            var size = 5;

            var matrix = new Matrix(size);

            Assert.IsInstanceOf<Matrix>(matrix);
        }
    }
}
