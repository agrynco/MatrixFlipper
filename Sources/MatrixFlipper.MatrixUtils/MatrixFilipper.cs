namespace MatrixFlipper.MatrixUtils
{
    public class MatrixFlipper
    {
        public void FlipClockwise(ref int[,] matrix)
        {
            int length = matrix.GetLength(0);

            for (int y = 0; y < length; y++)
            {
                for (int x = y + 1; x < length; x++)
                {
                    int tmp = matrix[y, x];
                    matrix[y, x] = matrix[x, y];
                    matrix[x, y] = tmp;
                }
            }

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < (length / 2); j++)
                {
                    int tmp = matrix[i, j];

                    matrix[i, j] = matrix[i, length - j - 1];
                    matrix[i, length - j - 1] = tmp;
                }
            }
        }
    }
}