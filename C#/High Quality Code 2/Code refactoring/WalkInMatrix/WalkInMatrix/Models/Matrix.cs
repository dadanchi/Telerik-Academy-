namespace WalkInMatrix.Models
{
    using System;
    using System.Text;
    using WalkInMatrix.Contracts;

    public class Matrix : IMatrix
    {
        private readonly int[] possibleDirectionsX = { 1, 1, 1, 0, -1, -1, -1, 0 };
        private readonly int[] possibleDirectionsY = { 1, 0, -1, -1, -1, 0, 1, 1 };
        private int size;
        private const int MaxSize = 100;
        private int[,] matrix;

        public Matrix(int size)
        {
            this.Size = size;
            matrix = new int[size, size];
        }

        public int Size
        {
            get
            {
                return this.size;
            }

            private set
            {
                if (value > MaxSize)
                {
                    throw new ArgumentException($"Size must not exceed {MaxSize}");
                }

                if (value < 0)
                {
                    throw new ArgumentException("Size cannot be neagtive");
                }

                this.size = value;
            }
        }

        public int this[int row, int col]
        {

            get
            {
                if (row > this.size || col > this.size || row < 0 || col < 0)
                {
                    throw new IndexOutOfRangeException("Index out of matrix");
                }

                return this.matrix[row, col];
            }

            set
            {
                if ((row > this.size || col > this.size || row < 0 || col < 0))
                {
                    throw new IndexOutOfRangeException("Index out of matrix");
                }

                this.matrix[row, col] = value;
            }
        }

        public void ChangeDirection(ICoordinate matrixCell)
        {
            int dx = matrixCell.X;
            int dy = matrixCell.Y;
            int currentDirectionIndex = 0;

            for (int count = 0; count < possibleDirectionsX.Length; count++)
            {
                if (possibleDirectionsX[count] == dx && possibleDirectionsY[count] == dy)
                {
                    currentDirectionIndex = count;
                    break;
                }
            }

            bool isLastIndex = currentDirectionIndex == possibleDirectionsX.Length - 1;

            if (isLastIndex)
            {
                matrixCell.X = possibleDirectionsX[0];
                matrixCell.Y = possibleDirectionsY[0];

            }
            else
            {
                matrixCell.X = possibleDirectionsX[currentDirectionIndex + 1];
                matrixCell.Y = possibleDirectionsY[currentDirectionIndex + 1];
            }
        }

        public bool HasEmptyNeighbourCells(ICoordinate matrixCell)
        {
            CheckMatrixBoundries(matrixCell);

            for (int count = 0; count < possibleDirectionsX.Length; count++)
            {
                if (this[matrixCell.X + possibleDirectionsX[count], matrixCell.Y + possibleDirectionsY[count]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public Coordinate FindNextEmptyCell(ICoordinate cell)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        return new Coordinate(row, col);
                    }
                }
            }

            return null;
        }

        public void Fill()
        {
            var matrixCell = new Coordinate(0, 0);
            var directionChange = new Coordinate(1, 1);

            int cellValue = 1;
            bool isOutOfMatrixBoundries = matrixCell.X + directionChange.X >= size || matrixCell.X + directionChange.X < 0 ||
                                          matrixCell.Y + directionChange.Y >= size || matrixCell.Y + directionChange.Y < 0 ||
                                          matrix[matrixCell.X + directionChange.X, matrixCell.Y + directionChange.Y] != 0;

            while (true)
            {
                matrix[matrixCell.X, matrixCell.Y] = cellValue;

                if (!this.HasEmptyNeighbourCells(matrixCell))
                {
                    matrixCell = this.FindNextEmptyCell(matrixCell);

                    if (matrixCell != null)
                    {
                        directionChange.X = 1;
                        directionChange.Y = 1;
                        cellValue++;

                        continue;
                    }
                    else
                    {
                        break;
                    }

                }

                if (isOutOfMatrixBoundries)
                {
                    this.ChangeDirection(directionChange);
                }

                matrixCell.X += directionChange.X;
                matrixCell.Y += directionChange.Y;
                cellValue++;

            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    result.AppendFormat("{0,3}", this[row, col]);
                }

                result.AppendLine();
            }

            return result.ToString();
        }

        private void CheckMatrixBoundries(ICoordinate matrixCell)
        {
            for (int count = 0; count < possibleDirectionsX.Length; count++)
            {
                bool xIsOutOfTheMatrix = matrixCell.X + possibleDirectionsX[count] >= size ||
                                         matrixCell.X + possibleDirectionsX[count] < 0;
                if (xIsOutOfTheMatrix)
                {
                    possibleDirectionsX[count] = 0;
                }

                bool yIsOutOfTheMatrix = matrixCell.Y + possibleDirectionsY[count] >= size ||
                                         matrixCell.Y + possibleDirectionsY[count] < 0;
                if (yIsOutOfTheMatrix)
                {
                    possibleDirectionsY[count] = 0;
                }
            }
        }
    }
}
