namespace WalkInMatrix.Tests.Models.Matrix
{
    using WalkInMatrix.Models;
    using WalkInMatrix.Contracts;

    using NUnit.Framework;
    using Moq;

    [TestFixture]
    public class FindNextEmptyCell_Should
    {
        [Test]
        public void ReturnNull_WhenThereAreNoEmptyCells()
        {
            var size = 1;
            var matrix = new Matrix(size);
            matrix[0, 0] = 1;

            var coordinateStub = new Mock<ICoordinate>();
            coordinateStub.SetupGet(s => s.X).Returns(0);
            coordinateStub.SetupGet(s => s.Y).Returns(0);

            var result = matrix.FindNextEmptyCell(coordinateStub.Object);

            Assert.IsNull(result);
        }

        [Test]
        public void ReturnNewCoordinate_WhenThereAreEmptyCells()
        {
            var size = 1;
            var matrix = new Matrix(size);

            var coordinateStub = new Mock<ICoordinate>();
            coordinateStub.SetupGet(s => s.X).Returns(0);
            coordinateStub.SetupGet(s => s.Y).Returns(0);

            var result = matrix.FindNextEmptyCell(coordinateStub.Object);

            Assert.IsInstanceOf<Coordinate>(result);
        }
    }
}
