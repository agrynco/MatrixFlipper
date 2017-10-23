using System;

namespace MatrixFlipper.MatrixUtils
{
    public class TheMatrixIsNotSquareException : Exception
    {
        public TheMatrixIsNotSquareException(int[,] matrix)
            : base($"The height and width of the matrix must be equal. Current height={matrix.GetLength(1)}, width={matrix.GetLength(1)}") { }
    }
}