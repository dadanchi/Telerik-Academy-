namespace WalkInMatrix.Tests.Models.Matrix
{
    using System;

    using NUnit.Framework;
    using WalkInMatrix.Models;

    [TestFixture]
    public class Indexation_Should
    {
        [Test]
        public void ThrowIndexOutOfRangeException_WhenInvalidIndexIsProvidedInSetting()
        {
            var size = 5;
            var matrix = new Matrix(size);

            Assert.Throws<IndexOutOfRangeException>(() => matrix[size + 1, size + 1] = 2);
        }

        [Test]
        public void ThrowIndexOutOfRangeException_WhenInvalidIndexIsProvidedInGetting()
        {
            var size = 5;
            var matrix = new Matrix(size);
            int testNumber;

            Assert.Throws<IndexOutOfRangeException>(() => testNumber = matrix[size + 1, size + 1]);
        }

        [Test]
        public void SetValueInTheIndexedCell_WhenProperIndexIsProvided()
        {
            int size = 5;
            var matrix = new Matrix(size);
            int testNumber = 1;

            matrix[size - 1, size - 1] = testNumber;

            Assert.AreEqual(testNumber, matrix[size - 1, size - 1]);
        }

        [Test]
        public void ReturnTheValueInTheIndexedCell_WhenProperIndexIsProvided()
        {
            int size = 5;
            var matrix = new Matrix(size);
            int testNumber;

            testNumber = matrix[size - 1, size - 1];

            Assert.AreEqual(testNumber, matrix[size - 1, size - 1]);
        }
    }
}
