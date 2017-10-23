using System.IO;

using AGrynCo.Lib.ResourcesUtils;

using NUnit.Framework;

namespace MatrixFlipper.MatrixUtils.Tests
{
    [TestFixture]
    public class MatrixReaderFromCsvTests
    {
        [Test]
        public void Flip_ShouldRise_TheMatrixIsNotSquareException()
        {
            //Arrange
            int[,] matrix =
            {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 }
            };

            var target = new MatrixFlipper();

            //Act
            Assert.Throws<TheMatrixIsNotSquareException>(() => target.FlipClockwise(ref matrix));
        }

        [Test]
        public void ReadFromEmptyFile()
        {
            //Arrange
            var target = new MatrixReaderFromCsv();

            //Act
            int[,] matrix = target.Read(new StreamReader(ResourceReader.GetStream(GetType(),
                "MatrixFlipper.MatrixUtils.Tests.MatrixEmpty.csv")));

            //Asserts
            Assert.AreEqual(0, matrix.Length);
        }

        [Test]
        public void ReadNonEmptyFile()
        {
            //Arrange
            var target = new MatrixReaderFromCsv();

            //Act
            int[,] matrix = target.Read(new StreamReader(ResourceReader.GetStream(GetType(),
                "MatrixFlipper.MatrixUtils.Tests.Matrix.csv")));

            //Asserts
            Assert.AreEqual(9, matrix.Length);
        }
    }
}