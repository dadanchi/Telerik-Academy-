using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkInMatrix.Contracts
{
    using WalkInMatrix.Models;

    public interface IMatrix
    {
        int Size { get; }

        int this[int row, int col] { get; set; }

        void ChangeDirection(ICoordinate matrixCell);

        bool HasEmptyNeighbourCells(ICoordinate matrixCell);

        Coordinate FindNextEmptyCell(ICoordinate cell);

        void Fill();
    }
}
