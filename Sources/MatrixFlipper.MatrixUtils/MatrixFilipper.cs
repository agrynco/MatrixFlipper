namespace MatrixFlipper.MatrixUtils
{
    public static class MatrixFilipper
    {
        public static void FlippClockwise(ref int[,] matrix)
        {
            int xLength = matrix.GetLength(0);
            int yLength = matrix.GetLength(1);

            for (int i = 0; i < xLength; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int tmp = matrix[i, j];

                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = tmp;
                }
            }
        }
    }
}