using System.IO;

using NUnit.Framework;

namespace MatrixFlipper.MatrixUtils.Tests
{
    [TestFixture]
    public class MatrixWriterToCsvTests
    {
        [Test]
        public void Write()
        {
            //Arrange
            var stream = new MemoryStream();
            var target = new MatrixWriterToCsv(new StreamWriter(stream));

            //Act
            target.Write(new[,]
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                    { 7, 8, 9 }
                }
            );

            stream.Position = 0;

            //Asserts
            TextReader reader = new StreamReader(stream);
            string content = reader.ReadToEnd();
            Assert.AreEqual("1, 2, 3\r\n4, 5, 6\r\n7, 8, 9\r\n", content);
        }
    }
}