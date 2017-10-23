namespace MatrixFlipper.MatrixUtils {
    public abstract class MatrixFlipperBase
    {
        public void FlipClockwise(ref int[,] matrix)
        {
            if (matrix.GetLength(0) != matrix.GetLength(1))
            {
                throw new TheMatrixIsNotSquareException(matrix);
            }

            DoFlipClockwise(ref matrix);
        }

        protected abstract void DoFlipClockwise(ref int[,] matrix);
    }
}