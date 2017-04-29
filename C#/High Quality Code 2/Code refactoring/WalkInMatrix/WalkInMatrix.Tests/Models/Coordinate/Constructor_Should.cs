namespace WalkInMatrix.Tests.Models.Coordinate
{
    using System;

    using NUnit.Framework;

    using WalkInMatrix.Models;

    [TestFixture]
    public class Constructor_Should
    {
        [TestCase(0, 0)]
        [TestCase(10000, 10000)]

        public void SetProperValuesForXandY_WhenValidValuesAreProvided(int xValue, int yValue)
        {
            var coordinate = new Coordinate(xValue, yValue);

            Assert.AreEqual(xValue, coordinate.X);
            Assert.AreEqual(yValue, coordinate.Y);
        }

        [TestCase(0, -1)]
        [TestCase(-1, -1)]
        [TestCase(-1, 1)]
        public void ThrowArgumentOutOfRangeException_WhenValidValuesAreProvided
            (int xValue, int yValue)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Coordinate(xValue, yValue));
        }
    }
}
