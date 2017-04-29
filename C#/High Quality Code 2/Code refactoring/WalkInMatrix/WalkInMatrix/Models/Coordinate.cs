namespace WalkInMatrix.Models
{
    using System;
    using WalkInMatrix.Contracts;

    public class Coordinate : ICoordinate
    {
        private int xCoordinate;
        private int yCoordinate;

        public Coordinate(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X
        {
            get
            {
                return this.xCoordinate;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("X coordinate cannot be negative");
                }

                this.xCoordinate = value;
            }
        }


        public int Y
        {
            get
            {
                return this.yCoordinate;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Y coordinate cannot be negative");
                }
                this.yCoordinate = value;
            }
        }

    }
}
