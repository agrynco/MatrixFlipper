using NUnit.Framework;

namespace MatrixFlipper.MatrixUtils.Tests
{
    [TestFixture]
    public class MatrixFliperTests
    {
        [Test]
        public void FlipClockwise()
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
            matrix = MatrixFliper.FlipClockwise(matrix);

            //Asserts
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Assert.AreEqual(matrix[i, j], expected[i, j]);
                }
            }
        }
    }
}