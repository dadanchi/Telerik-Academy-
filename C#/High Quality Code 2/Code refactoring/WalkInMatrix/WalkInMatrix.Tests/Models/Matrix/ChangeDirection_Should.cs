namespace WalkInMatrix.Tests.Models.Matrix
{
    using WalkInMatrix.Models;
    using WalkInMatrix.Contracts;

    using NUnit.Framework;
    using Moq;

    [TestFixture]
    public class ChangeDirection_Should
    {
        // possibleDirectionsX = { 1, 1, 1, 0, -1, -1, -1, 0 };
        // possibleDirectionsY = { 1, 0, -1, -1, -1, 0, 1, 1 };
        [Test]
        public void SetProperCoordinates_WhenNeeded()
        {
            var coordinatesStub = new Mock<ICoordinate>();
            coordinatesStub.SetupAllProperties();
            coordinatesStub.Object.X = 1;
            coordinatesStub.Object.Y = 1;

            var size = 5;
            var matrix = new Matrix(size);

            matrix.ChangeDirection(coordinatesStub.Object);

            Assert.AreEqual(coordinatesStub.Object.X, 1);
            Assert.AreEqual(coordinatesStub.Object.Y, 0);
        }
    }
}
