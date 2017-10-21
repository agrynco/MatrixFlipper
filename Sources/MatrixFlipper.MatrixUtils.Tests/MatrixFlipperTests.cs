using NUnit.Framework;

namespace MatrixFlipper.MatrixUtils.Tests
{
    [TestFixture]
    public class MatrixFlipperTests
    {
        private static void AssertMatrix(int[,] matrix, int[,] expected)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Assert.AreEqual(matrix[i, j], expected[i, j]);
                }
            }
        }

        [Test]
        public void FlipClockwise_2x2()
        {
            //Arrange
            int[,] matrix =
            {
                { 1, 2 },
                { 3, 4 }
            };

            int[,] expected =
            {
                { 3, 1 },
                { 4, 2 }
            };

            //Act
            new MatrixFlipper().FlipClockwise(ref matrix);

            //Asserts
            AssertMatrix(matrix, expected);
        }

        [Test]
        public void FlipClockwise_3x3()
        {
            //Arrange
            int[,] matrix =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int[,] expected =
            {
                { 7, 4, 1 },
                { 8, 5, 2 },
                { 9, 6, 3 }
            };

            //Act
            new MatrixFlipper().FlipClockwise(ref matrix);

            //Asserts
            AssertMatrix(matrix, expected);
        }

        [Test]
        public void FlipClockwise_4x4()
        {
            //Arrange
            int[,] matrix =
            {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 },
                { 13, 14, 15, 16 }
            };

            int[,] expected =
            {
                { 13, 9, 5, 1 },
                { 14, 10, 6, 2 },
                { 15, 11, 7, 3 },
                { 16, 12, 8, 4 }
            };

            //Act
            new MatrixFlipper().FlipClockwise(ref matrix);

            //Asserts
            AssertMatrix(matrix, expected);
        }
    }
}