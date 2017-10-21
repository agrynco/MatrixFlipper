using System.IO;

using AGrynCo.Lib.ResourcesUtils;

using NUnit.Framework;

namespace MatrixFlipper.MatrixUtils.Tests
{
    [TestFixture]
    public class MatrixReaderFromCsvTests
    {
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