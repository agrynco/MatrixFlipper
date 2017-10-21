namespace MatrixFlipper.MatrixUtils
{
    public static class MatrixFiliper
    {
        public static void FlipClockwise(ref int[,] matrix)
        {
            int length = matrix.GetLength(0);

            for (int y = 0; y < length; y++)
            {
                for (int x = 0; x <= y; x++)
                {
                    int tmp = matrix[length - 1 - y, length - 1 - x];

                    matrix[length - 1 - y, length - 1 - x] = matrix[x, y];
                    matrix[x, y] = tmp;
                }
            }
        }
    }
}