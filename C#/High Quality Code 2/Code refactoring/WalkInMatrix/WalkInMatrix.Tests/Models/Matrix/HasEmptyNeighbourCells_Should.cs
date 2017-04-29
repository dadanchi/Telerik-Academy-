namespace WalkInMatrix.Tests.Models.Matrix
{
    using WalkInMatrix.Models;
    using WalkInMatrix.Contracts;

    using NUnit.Framework;
    using Moq;

    [TestFixture]
    public class HasEmptyNeighbourCells_Should
    {
        [Test]
        public void ReturnTrue_WhenEmpyNeighbourCellsAreAvailable()
        {
            var size = 5;
            var matrix = new Matrix(size);

            var coordinateStub = new Mock<ICoordinate>();
            coordinateStub.SetupGet(s => s.X).Returns(0);
            coordinateStub.SetupGet(s => s.Y).Returns(0);

            bool hasEmptyCells = matrix.HasEmptyNeighbourCells(coordinateStub.Object);

            Assert.IsTrue(hasEmptyCells);
        }

        [Test]
        public void ReturnFalse_WhenNoEmpyNeighbourCellsAreAvailable()
        {
            var size = 1;
            var matrix = new Matrix(size);
            matrix[0, 0] = 1;

            var coordinateStub = new Mock<ICoordinate>();
            coordinateStub.SetupGet(s => s.X).Returns(0);
            coordinateStub.SetupGet(s => s.Y).Returns(0);

            bool hasEmptyCells = matrix.HasEmptyNeighbourCells(coordinateStub.Object);

            Assert.IsFalse(hasEmptyCells);
        }
    }
}
