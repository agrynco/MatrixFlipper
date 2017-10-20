using MatrixFlipper.MatrixUtils;

namespace MatrixFlipper.Console
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            int[,] matrix =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            MatrixFilipper.FlippClockwise(ref matrix);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    System.Console.Write($"{matrix[i, j]} ");
                }

                System.Console.WriteLine();
            }
        }
    }
}